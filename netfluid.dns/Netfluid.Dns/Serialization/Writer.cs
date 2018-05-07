using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Netfluid.Dns.Internals;

namespace Netfluid.Dns.Serialization
{
    internal class Writer
    {
        public static byte[] Serialize(Response response)
        {
            var ms = new MemoryStream();

            response.Header.QDCOUNT = (ushort) response.Questions.Count;
            response.Header.ANCOUNT = (ushort) response.Answers.Count;
            response.Header.NSCOUNT = (ushort) response.Authorities.Count;
            response.Header.ARCOUNT = (ushort) response.Additionals.Count;

            Serialize(ms, response.Header);

            response.Questions.ForEach(x => Serialize(ms, x));
            response.Answers.ForEach(x => Serialize(ms, x));
            response.Authorities.ForEach(x => Serialize(ms, x));
            response.Additionals.ForEach(x => Serialize(ms, x));

            return ms.ToArray();
        }

        public static void Serialize(Stream ms, Record rr)
        {
            WriteDomainName(ms, rr.Name);
            WriteUInt16(ms, (ushort) Enum.Parse(typeof(RecordType), rr.GetType().Name.Substring("Record".Length)));
            WriteUInt16(ms, (ushort) rr.Class);
            WriteUInt32(ms, rr.TTL);

            var n = new MemoryStream();

            var type = rr.GetType();
            foreach (var field in type.GetFields().Where(x => x.DeclaringType == type))
            {
                var fieldType = field.FieldType;
                var value = field.GetValue(rr);

                if (fieldType == typeof(byte))
                {
                    ms.WriteByte((byte) value);
                }
                else if (fieldType == typeof(ushort))
                {
                    WriteUInt16(ms, (ushort) value);
                }
                else if (fieldType == typeof(int))
                {
                    WriteInt32(ms, (int) value);
                }
                else if (fieldType == typeof(uint))
                {
                    WriteUInt32(ms, (uint) value);
                }
                else if (fieldType == typeof(byte[]))
                {
                    var array = (byte[]) value;
                    ms.Write(array, 0, array.Length);
                }
                else if (fieldType == typeof(string))
                {
                    if (field.HasAttribute<DomainNameAttribute>())
                        WriteDomainName(ms, (string) value);
                    else
                        WriteText(ms, (string) value);
                }
            }

            WriteUInt16(ms, (ushort) n.Length);
            n.CopyTo(ms);
        }

        public static void Serialize(Stream ms, Header header)
        {
            WriteUInt16(ms, header.ID);
            WriteUInt16(ms, header.Flags);
            WriteUInt16(ms, header.QDCOUNT);
            WriteUInt16(ms, header.ANCOUNT);
            WriteUInt16(ms, header.NSCOUNT);
            WriteUInt16(ms, header.ARCOUNT);
        }

        public static byte[] Serialize(Request request)
        {
            var data = new MemoryStream();
            request.Header.QDCOUNT = (ushort) request.Count;

            Serialize(data, request.Header);

            foreach (var q in request)
                Serialize(data, q);

            return data.ToArray();
        }

        public static void Serialize(Stream ms, Question q)
        {
            WriteDomainName(ms, q.Name);
            WriteUInt16(ms, (ushort) q.Type);
            WriteUInt16(ms, (ushort) q.Class);
        }

        private static void WriteUInt16(Stream ms, ushort value)
        {
            if (BitConverter.IsLittleEndian)
            {
                ms.WriteByte((byte) ((value >> 8) & 0xff));
                ms.WriteByte((byte) (value & 0xff));
                return;
            }
            ms.WriteByte((byte) (value & 0xff));
            ms.WriteByte((byte) ((value >> 8) & 0xff));
        }

        private static IEnumerable<byte> WriteShort(ushort sValue)
        {
            return BitConverter.GetBytes(IPAddress.HostToNetworkOrder((short) sValue));
        }

        private static void WriteInt32(Stream ms, int value)
        {
            if (BitConverter.IsLittleEndian)
            {
                ms.WriteByte((byte) ((value >> 24) & 0xff));
                ms.WriteByte((byte) ((value >> 16) & 0xff));
                ms.WriteByte((byte) ((value >> 8) & 0xff));
                ms.WriteByte((byte) (value & 0xff));
            }
            else
            {
                ms.WriteByte((byte) (value & 0xff));
                ms.WriteByte((byte) ((value >> 8) & 0xff));
                ms.WriteByte((byte) ((value >> 16) & 0xff));
                ms.WriteByte((byte) ((value >> 24) & 0xff));
            }
        }

        private static void WriteUInt32(Stream ms, uint value)
        {
            if (BitConverter.IsLittleEndian)
            {
                ms.WriteByte((byte) ((value >> 24) & 0xff));
                ms.WriteByte((byte) ((value >> 16) & 0xff));
                ms.WriteByte((byte) ((value >> 8) & 0xff));
                ms.WriteByte((byte) (value & 0xff));
                return;
            }
            ms.WriteByte((byte) (value & 0xff));
            ms.WriteByte((byte) ((value >> 8) & 0xff));
            ms.WriteByte((byte) ((value >> 16) & 0xff));
            ms.WriteByte((byte) ((value >> 24) & 0xff));
        }

        public static void WriteText(Stream ms, string name)
        {
            var d = Encoding.ASCII.GetBytes(name);
            ms.Write(d, 0, d.Length);
        }

        private static void WriteDomainName(Stream ms, string name)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(name) || name == ".")
                {
                    ms.WriteByte(0);
                    return;
                }

                var labelLength = name.IndexOf('.');
                if (labelLength == -1)
                    labelLength = name.Length;

                ms.WriteByte((byte) labelLength);

                var array = Encoding.ASCII.GetBytes(name.ToCharArray(0, labelLength));
                ms.Write(array, 0, array.Length);

                name = labelLength == name.Length ? "." : name.Substring(labelLength + 1);
            }
        }
    }
}