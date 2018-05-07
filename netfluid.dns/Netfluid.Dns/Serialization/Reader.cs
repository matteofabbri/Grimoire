using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Netfluid.Dns.Internals;

namespace Netfluid.Dns.Serialization
{
    internal class Reader
    {
        private static byte ReadByte(Stream stream)
        {
            return (byte) stream.ReadByte();
        }

        private static ushort ReadUInt16(Stream stream)
        {
            return (ushort) ((stream.ReadByte() << 8) | stream.ReadByte());
        }

        private static uint ReadUInt32(Stream ms)
        {
            if (BitConverter.IsLittleEndian)
                return ((uint) ReadByte(ms) << 24) | ((uint) ReadByte(ms) << 16) |
                       ((uint) ReadByte(ms) << 8) | ReadByte(ms);

            return ReadByte(ms) | ((uint) ReadByte(ms) << 8) | ((uint) ReadByte(ms) << 16) |
                   ((uint) ReadByte(ms) << 24);
        }

        private static int ReadInt32(Stream ms)
        {
            int res;

            if (BitConverter.IsLittleEndian)
                res = (ReadByte(ms) << 24) | (ReadByte(ms) << 16) |
                      (ReadByte(ms) << 8) | ReadByte(ms);
            else
                res = ReadByte(ms) | (ReadByte(ms) << 8) |
                      (ReadByte(ms) << 16) | (ReadByte(ms) << 24);

            return res;
        }

        private static byte[] ReadByteArray(Stream ms, int size)
        {
            var value = new byte[size];
            ms.Read(value, 0, value.Length);
            return value;
        }

        private static string ReadText(Stream ms)
        {
            var s = ms.ReadByte();
            var b = new byte[s];
            ms.Read(b, 0, b.Length);
            return Encoding.ASCII.GetString(b);
        }

        private static void ParseDomainName(byte[] resultData, ref int currentPosition, StringBuilder sb)
        {
            while (true)
            {
                if (currentPosition >= resultData.Length)
                    return;

                var currentByte = resultData[currentPosition++];
                if (currentByte == 0)
                    return;
                if (currentByte >= 192)
                {
                    // Pointer, RFC1035
                    int pointer;
                    if (BitConverter.IsLittleEndian)
                        pointer = (ushort) (((currentByte - 192) << 8) | resultData[currentPosition++]);
                    else
                        pointer = (ushort) ((currentByte - 192) | (resultData[currentPosition++] << 8));

                    ParseDomainName(resultData, ref pointer, sb);

                    return;
                }
                if (currentByte == 65)
                {
                    // binary EDNS label, RFC2673, RFC3363, RFC3364
                    int length = resultData[currentPosition++];
                    if (length == 0)
                        length = 256;

                    sb.Append(@"\[x");
                    var suffix = "/" + length + "]";

                    do
                    {
                        currentByte = resultData[currentPosition++];
                        if (length < 8)
                            currentByte &= (byte) (0xff >> (8 - length));

                        sb.Append(currentByte.ToString("x2"));

                        length = length - 8;
                    } while (length > 0);

                    sb.Append(suffix);
                }
                else if (currentByte >= 64)
                {
                    // extended dns label RFC 2671
                    var kk = resultData.Skip(currentPosition + 1).ToArray();
                    sb.Append(Encoding.UTF8.GetString(kk));
                    return;
                }
                else
                {
                    if (currentPosition + currentByte > resultData.Length)
                        currentByte = (byte) (resultData.Length - currentPosition);
                    // append additional text part
                    sb.Append(Encoding.ASCII.GetString(resultData, currentPosition, currentByte));
                    sb.Append(".");
                    currentPosition += currentByte;
                }
            }
        }

        private static string ReadDomainName(MemoryStream stream)
        {
            var sb = new StringBuilder();
            var pos = (int) stream.Position;

            ParseDomainName(stream.ToArray(), ref pos, sb);
            stream.Position = pos;
            return sb.Length == 0 ? string.Empty : sb.ToString(0, sb.Length - 1);
        }

        private static Header ReadHeader(Stream stream)
        {
            return new Header
            {
                ID = ReadUInt16(stream),
                Flags = ReadUInt16(stream),
                QDCOUNT = ReadUInt16(stream),
                ANCOUNT = ReadUInt16(stream),
                NSCOUNT = ReadUInt16(stream),
                ARCOUNT = ReadUInt16(stream)
            };
        }

        private static Question ReadQuestion(MemoryStream stream)
        {
            return new Question(ReadDomainName(stream), (RecordType) ReadUInt16(stream),
                (RecordClass) ReadUInt16(stream));
        }

        public static Request ReadRequest(MemoryStream stream)
        {
            var req = new Request {Header = ReadHeader(stream)};

            for (var i = 0; i < req.Header.QDCOUNT; i++)
                req.Add(ReadQuestion(stream));
            return req;
        }

        private static Record ReadRecord(MemoryStream ms)
        {
            const int timeLived = 0;
            var name = ReadDomainName(ms);
            var recordType = (RecordType) ReadUInt16(ms);
            var @class = (RecordClass) ReadUInt16(ms);
            var ttl = ReadUInt32(ms);
            var rdlength = ReadUInt16(ms);

            var record = Record.FromType(recordType);
            var type = record.GetType();

            int length = rdlength;

            record.TimeLived = timeLived;
            record.Name = name;
            record.Class = @class;
            record.TTL = ttl;

            var nspos = ms.Position + rdlength;

            foreach (var field in type.GetFields().Where(x => x.DeclaringType == type))
            {
                var fieldType = field.FieldType;

                if (fieldType == typeof(byte))
                    field.SetValue(record, (byte) ms.ReadByte());
                else if (fieldType == typeof(ushort))
                    field.SetValue(record, ReadUInt16(ms));
                else if (fieldType == typeof(int))
                    field.SetValue(record, ReadInt32(ms));
                else if (fieldType == typeof(uint))
                    field.SetValue(record, ReadUInt32(ms));
                else if (fieldType == typeof(byte[]))
                    field.SetValue(record, ReadByteArray(ms, length));
                else if (fieldType == typeof(string))
                    if (field.HasAttribute<DomainNameAttribute>())
                        field.SetValue(record, ReadDomainName(ms));
                    else
                        field.SetValue(record, ReadText(ms));
            }

            if (nspos > ms.Position)
                ms.Position = nspos;
            return record;
        }

        public static Response ReadResponse(byte[] data)
        {
            var ms = new MemoryStream(data);

            var r = new Response
            {
                MessageSize = data.Length,
                Questions = new List<Question>(),
                Answers = new List<Record>(),
                Authorities = new List<Record>(),
                Additionals = new List<Record>(),
                Header = ReadHeader(ms)
            };


            for (var intI = 0; intI < r.Header.QDCOUNT; intI++)
                r.Questions.Add(ReadQuestion(ms));

            for (var intI = 0; intI < r.Header.ANCOUNT; intI++)
                r.Answers.Add(ReadRecord(ms));

            for (var intI = 0; intI < r.Header.NSCOUNT; intI++)
                r.Authorities.Add(ReadRecord(ms));
            for (var intI = 0; intI < r.Header.ARCOUNT; intI++)
                r.Additionals.Add(ReadRecord(ms));

            return r;
        }
    }
}