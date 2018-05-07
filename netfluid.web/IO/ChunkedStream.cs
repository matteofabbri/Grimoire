// ********************************************************************************************************
// <copyright company="NetFluid">
//     Copyright (c) 2013 Matteo Fabbri. All rights reserved.
// </copyright>
// ********************************************************************************************************
// The contents of this file are subject to the GNU AGPL v3.0 (the "License"); 
// you may not use this file except in compliance with the License. You may obtain a copy of the License at 
// http://www.fsf.org/licensing/licenses/agpl-3.0.html 
// 
// Commercial licenses are also available from http://netfluid.org/, including free evaluation licenses.
//
// Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF 
// ANY KIND, either express or implied. See the License for the specific language governing rights and 
// limitations under the License. 
// 
// The Initial Developer of this file is Matteo Fabbri.
// 
// Contributor(s): (Open source contributors should list themselves and their modifications here). 
// Change Log: 
// Date           Changed By      Notes
// 23/10/2013    Matteo Fabbri      Inital coding
// ********************************************************************************************************

using System;
using System.IO;
using System.Text;

namespace Netfluid.IO
{
    [Serializable]
    internal class ChunkedStream : Stream
    {
        private static readonly byte[] CRLF;
        private static readonly byte[] ENDTRAIL /*= new byte[] {48,13,10,13,10}*/;
        private readonly Stream stream;

        static ChunkedStream()
        {
            CRLF = Encoding.UTF8.GetBytes("\r\n");
            ENDTRAIL = Encoding.UTF8.GetBytes("0\r\n\r\n");
        }

        public ChunkedStream(Stream stream)
        {
            this.stream = stream;
        }

        public override bool CanRead
        {
            get { return stream.CanRead; }
        }

        public override bool CanSeek
        {
            get { return stream.CanSeek; }
        }

        public override bool CanWrite
        {
            get { return stream.CanWrite; }
        }

        public override long Length
        {
            get { return stream.Length; }
        }

        public override long Position
        {
            get { return stream.Position; }
            set { stream.Position = value; }
        }

        public override void Flush()
        {
            stream.Flush();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return stream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            stream.SetLength(value);
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return stream.Read(buffer, offset, count);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            try
            {
                byte[] octet = Encoding.ASCII.GetBytes(String.Format("{0:x}\r\n", count));

                stream.Write(octet, 0, octet.Length);
                ///stream.Write(CRLF, 0, CRLF.Length);

                stream.Write(buffer, offset, count);

                stream.Write(CRLF, 0, CRLF.Length);
            }
            catch (Exception)
            {
            }
        }

        public override void Close()
        {
            try
            {
                stream.Write(ENDTRAIL, 0, 5);
                stream.Flush();
                stream.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}