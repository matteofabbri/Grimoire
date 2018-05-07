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

namespace Netfluid
{
    /// <summary>
    /// Send a file to the client (http://stackoverflow.com/questions/1012437/uses-of-content-disposition-in-an-http-response-header)
    /// </summary>
    public class FileResponse : IResponse
    {
        /// <summary>
        /// Get or set file size exposed to the client
        /// </summary>
        public long FileSize { get; set; }

        /// <summary>
        /// Get or set file name exposed to the client
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// File to send physical path
        /// </summary>
        public Stream Stream { get; set; }

        /// <summary>
        ///  Get or set file mime type exposed to the client
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// Send this file to client faking filename and mimetype
        /// </summary>
        /// <param name="filepath">original file path</param>
        /// <param name="filename">overrided file name</param>
        /// <param name="mimetype">overrided mime type</param>
        public FileResponse(Stream stream, string filename, string mimetype)
        {
            Stream = stream;
            FileName = filename;
            MimeType = mimetype;
            FileSize = stream.Length;
        }


        /// <summary>
        /// Send this file to client faking filename and mimetype
        /// </summary>
        /// <param name="filepath">original file path</param>
        /// <param name="filename">overrided file name</param>
        /// <param name="mimetype">overrided mime type</param>
        public FileResponse(string filepath, string filename, string mimetype)
        {
            Stream = new FileStream(filepath, FileMode.Open,FileAccess.Read,FileShare.Read);
            FileName = filename;
            MimeType = mimetype;
            FileSize = Stream.Length;
        }

        /// <summary>
        ///  Send this file to client faking filename
        /// </summary>
        /// <param name="filepath">original file path</param>
        /// <param name="filename">overrided file name</param>
        public FileResponse(string filepath, string filename)
        {
            Stream = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read);
            FileName = filename;
            MimeType = MimeTypes.GetType(filepath);
            FileSize = Stream.Length;
        }

        /// <summary>
        /// Send this file to client.
        /// </summary>
        /// <param name="filepath"></param>
        public FileResponse(string filepath)
        {
            Stream = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read);
            FileName = System.IO.Path.GetFileName(filepath);
            MimeType = MimeTypes.GetType(filepath);
            FileSize = Stream.Length;
        }

        public FileResponse(System.IO.Stream stream, string filename)
        {
            // TODO: Complete member initialization
            this.Stream = stream;
            FileName = filename;
            MimeType = MimeTypes.GetType(filename);
            FileSize = Stream.Length;
        }

        public void SetHeaders(Context cnt)
        {
            cnt.Response.ContentLength64 = FileSize;
            cnt.Response.Headers["Content-Disposition"] = "attachment; filename=\"" + FileName + "\"";
            cnt.Response.ContentType = MimeType;
        }

        /// <summary>
        /// Send the file to client
        /// </summary>
        /// <param name="cnt">client context</param>
        public void SendResponse(Context cnt)
        {
            var fs = Stream;

            if (cnt.Request.Headers["Range"]!=null && cnt.Request.Headers["Range"].StartsWith("bytes="))
            {
                var r = cnt.Request.Headers["Range"].Substring("bytes=".Length);
                var index = r.IndexOf('/');

                if (index >= 0) r = r.Substring(0, index);

                var parts = r.Split(new[]{'-'}, StringSplitOptions.None);

                var from = int.Parse(parts[0] == string.Empty ? "0" : parts[0]);
                var to = int.Parse(parts[1] == string.Empty ? "0" : parts[1]);

                fs.Seek(from, SeekOrigin.Begin);

                if (to!=0)
                {
                    fs.CopyTo(cnt.Response.OutputStream);
                }
                cnt.Response.Headers.Set("Content-Range", "bytes " + from + "-" + to + "/" + (long)(from - to));
            }

            fs.CopyTo(cnt.Response.OutputStream);
            fs.Close();
        }

        public void Dispose()
        {
            Stream.Dispose();
        }
    }
}