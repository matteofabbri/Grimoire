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
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Netfluid
{
    /// <summary>
    /// Retrieve mime type of files
    /// </summary>
    public static class MimeTypes
    {
        private static readonly Dictionary<string, string> mimetypes;
        private static readonly char[] separator;

        static MimeTypes()
        {
            separator = new[] {Path.DirectorySeparatorChar};

            mimetypes = new Dictionary<string, string>
            {
                {".c", "text/plain"},
                {".h", "text/plain"},
                {".i", "text/plain"},
                {".s", "text/plain"},
                {".z", "application/x-compress"},
                {".vb", "text/plain"},
                {".cc", "text/plain"},
                {".rc", "text/plain"},
                {".cd", "text/plain"},
                {".ai", "application/postscript"},
                {".mk", "text/plain"},
                {".wm", "video/x-ms-wm"},
                {".cs", "text/plain"},
                {".ps", "application/postscript"},
                {".ts", "video/vnd.dlna.mpeg-tts"},
                {".au", "audio/basic"},
                {".py", "text/plain"},
                {".js", "application/javascript"},
                {".gz", "application/x-gzip"},
                {".tga", "image/targa"},
                {".xla", "application/vnd.ms-excel"},
                {".wma", "audio/x-ms-wma"},
                {".mpa", "video/mpeg"},
                {".ppa", "application/vnd.ms-powerpoint"},
                {".asa", "application/xml"},
                {".hta", "application/hta"},
                {".ova", "application/x-virtualbox-ova"},
                {".hxa", "application/xml"},
                {".dib", "image/bmp"},
                {".pub", "application/vnd.ms-publisher"},
                {".aac", "audio/vnd.dlna.adts"},
                {".odc", "text/x-ms-odc"},
                {".inc", "text/plain"},
                {".doc", "application/msword"},
                {".spc", "application/x-pkcs7-certificates"},
                {".wsc", "text/scriptlet"},
                {".xsc", "application/xml"},
                {".htc", "text/x-component"},
                {".svc", "application/xml"},
                {".hxc", "application/xml"},
                {".mid", "audio/mid"},
                {".wmd", "application/x-ms-wmd"},
                {".snd", "audio/basic"},
                {".cod", "text/plain"},
                {".mod", "video/mpeg"},
                {".vsd", "application/vnd.ms-visio.viewer"},
                {".xsd", "application/xml"},
                {".dtd", "application/xml-dtd"},
                {".hxd", "application/octet-stream"},
                {".jpe", "image/jpeg"},
                {".mpe", "video/mpeg"},
                {".ttf", "application/x-font-ttf"},
                {".exe", "application/x-msdownload"},
                {".hxe", "application/xml"},
                {".vcf", "text/x-vcard"},
                {".fdf", "application/vnd.fdf"},
                {".pdf", "application/pdf"},
                {".def", "text/plain"},
                {".aif", "audio/aiff"},
                {".fif", "application/fractals"},
                {".gif", "image/gif"},
                {".rmf", "application/vnd.adobe.rmf"},
                {".prf", "application/pics-rules"},
                {".srf", "text/plain"},
                {".asf", "video/x-ms-asf"},
                {".rtf", "application/msword"},
                {".ovf", "application/x-virtualbox-ovf"},
                {".swf", "application/x-shockwave-flash"},
                {".hxf", "application/xml"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".mpg", "video/mpeg"},
                {".odh", "text/plain"},
                {".tlh", "text/plain"},
                {".hxh", "application/octet-stream"},
                {".tli", "text/plain"},
                {".rmi", "audio/mid"},
                {".vsi", "application/ms-vsi"},
                {".gui", "text/plain"},
                {".avi", "video/avi"},
                {".hxi", "application/octet-stream"},
                {".mak", "text/plain"},
                {".wbk", "application/msword"},
                {".slk", "application/vnd.ms-excel"},
                {".xlk", "application/vnd.ms-excel"},
                {".hxk", "application/xml"},
                {".idl", "text/plain"},
                {".odl", "text/plain"},
                {".dll", "application/x-msdownload"},
                {".xll", "application/vnd.ms-excel"},
                {".eml", "message/rfc822"},
                {".xml", "text/xml"},
                {".inl", "text/plain"},
                {".sol", "text/plain"},
                {".spl", "application/futuresplash"},
                {".wpl", "application/vnd.ms-wpl"},
                {".crl", "application/pkix-crl"},
                {".xsl", "text/xml"},
                {".stl", "application/vnd.ms-pki.stl"},
                {".xlm", "application/vnd.ms-excel"},
                {".asm", "text/plain"},
                {".htm", "text/html"},
                {".man", "application/x-troff-man"},
                {".sln", "text/plain"},
                {".ico", "image/x-icon"},
                {".pko", "application/vnd.ms-pki.pko"},
                {".map", "text/plain"},
                {".mdp", "text/plain"},
                {".odp", "application/vnd.oasis.opendocument.presentation"},
                {".vdp", "text/plain"},
                {".wdp", "image/vnd.ms-photo"},
                {".xdp", "application/vnd.adobe.xdp+xml"},
                {".mfp", "application/x-shockwave-flash"},
                {".zip", "application/x-zip-compressed"},
                {".bmp", "image/bmp"},
                {".cpp", "text/plain"},
                {".hpp", "text/plain"},
                {".dsp", "text/plain"},
                {".wiq", "application/xml"},
                {".hxq", "application/octet-stream"},
                {".tar", "application/x-tar"},
                {".xdr", "application/xml"},
                {".cer", "application/x-x509-ca-cert"},
                {".der", "application/x-x509-ca-cert"},
                {".air", "application/vnd.adobe.air-application-installer-package+zip"},
                {".sor", "text/plain"},
                {".cur", "text/plain"},
                {".hxr", "application/octet-stream"},
                {".ods", "application/vnd.oasis.opendocument.spreadsheet"},
                {".rgs", "text/plain"},
                {".mis", "text/plain"},
                {".ols", "application/vnd.ms-publisher"},
                {".xls", "application/vnd.ms-excel"},
                {".eps", "application/postscript"},
                {".pps", "application/vnd.ms-powerpoint"},
                {".xps", "application/vnd.ms-xpsdocument"},
                {".css", "text/css"},
                {".iss", "text/plain"},
                {".rss", "message/rfc822"},
                {".vss", "application/vnd.ms-visio.viewer"},
                {".xss", "application/xml"},
                {".mts", "video/vnd.dlna.mpeg-tts"},
                {".tts", "video/vnd.dlna.mpeg-tts"},
                {".nws", "message/rfc822"},
                {".hxs", "application/octet-stream"},
                {".cat", "application/vnd.ms-pki.seccat"},
                {".rat", "application/rat-file"},
                {".rct", "text/plain"},
                {".sct", "text/scriptlet"},
                {".adt", "audio/vnd.dlna.adts"},
                {".odt", "application/vnd.oasis.opendocument.text"},
                {".mht", "message/rfc822"},
                {".xht", "application/xhtml+xml"},
                {".sit", "application/x-stuffit"},
                {".xlt", "application/vnd.ms-excel"},
                {".dot", "application/msword"},
                {".pot", "application/vnd.ms-powerpoint"},
                {".ppt", "application/vnd.ms-powerpoint"},
                {".crt", "application/x-x509-ca-cert"},
                {".lst", "text/plain"},
                {".sst", "application/vnd.ms-pki.certstore"},
                {".vst", "application/vnd.ms-visio.viewer"},
                {".hxt", "application/xml"},
                {".txt", "text/plain"},
                {".wav", "audio/wav"},
                {".wmv", "video/x-ms-wmv"},
                {".mov", "video/quicktime"},
                {".csv", "application/vnd.ms-excel"},
                {".hxv", "application/xml"},
                {".xlw", "application/vnd.ms-excel"},
                {".dsw", "text/plain"},
                {".hxw", "application/octet-stream"},
                {".pyw", "text/plain"},
                {".wax", "audio/x-ms-wax"},
                {".pdx", "application/vnd.adobe.pdx"},
                {".vdx", "application/vnd.ms-visio.viewer"},
                {".pfx", "application/x-pkcs12"},
                {".wmx", "video/x-ms-wmx"},
                {".hqx", "application/mac-binhex40"},
                {".trx", "application/xml"},
                {".asx", "video/x-ms-asf"},
                {".fsx", "application/fsharp-script"},
                {".vsx", "application/vnd.ms-visio.viewer"},
                {".jtx", "application/x-jtx+xps"},
                {".mtx", "application/xml"},
                {".vtx", "application/vnd.ms-visio.viewer"},
                {".wvx", "video/x-ms-wvx"},
                {".cxx", "text/plain"},
                {".hxx", "text/plain"},
                {".iqy", "text/x-ms-iqy"},
                {".rqy", "text/x-ms-rqy"},
                {".tgz", "application/x-compressed"},
                {".wiz", "application/msword"},
                {".wmz", "application/x-ms-wmz"},
                {".pwz", "application/vnd.ms-powerpoint"},
                {".xmta", "application/xml"},
                {".xlsb", "application/vnd.ms-excel.sheet.binary.macroEnabled.12"},
                {".aifc", "audio/aiff"},
                {".rdlc", "application/xml"},
                {".xfdf", "application/vnd.adobe.xfdf"},
                {".aiff", "audio/aiff"},
                {".jfif", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".mpeg", "video/mpeg"},
                {".midi", "audio/mid"},
                {".wsdl", "application/xml"},
                {".xaml", "application/xaml+xml"},
                {".dgml", "application/xml"},
                {".xoml", "text/plain"},
                {".html", "text/html"},
                {".xlam", "application/vnd.ms-excel.addin.macroEnabled.12"},
                {".ppam", "application/vnd.ms-powerpoint.addin.macroEnabled.12"},
                {".docm", "application/vnd.ms-word.document.macroEnabled.12"},
                {".sldm", "application/vnd.ms-powerpoint.slide.macroEnabled.12"},
                {".xlsm", "application/vnd.ms-excel.sheet.macroEnabled.12"},
                {".ppsm", "application/vnd.ms-powerpoint.slideshow.macroEnabled.12"},
                {".xltm", "application/vnd.ms-excel.template.macroEnabled.12"},
                {".dotm", "application/vnd.ms-word.template.macroEnabled.12"},
                {".potm", "application/vnd.ms-powerpoint.template.macroEnabled.12"},
                {".pptm", "application/vnd.ms-powerpoint.presentation.macroEnabled.12"},
                {".skin", "application/xml"},
                {".vsto", "application/x-ms-vsto"},
                {".xbap", "application/x-ms-xbap"},
                {".jnlp", "application/x-java-jnlp-file"},
                {".wlmp", "application/wlmoviemaker"},
                {".user", "text/plain"},
                {".adts", "audio/vnd.dlna.adts"},
                {".vsct", "text/xml"},
                {".xslt", "application/xml"},
                {".asax", "application/xml"},
                {".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document"},
                {".ascx", "application/xml"},
                {".sldx", "application/vnd.openxmlformats-officedocument.presentationml.slide"},
                {".osdx", "application/opensearchdescription+xml"},
                {".dwfx", "model/vnd.dwfx+xps"},
                {".ashx", "application/xml"},
                {".vsix", "application/vsix"},
                {".thmx", "application/vnd.ms-officetheme"},
                {".asmx", "application/xml"},
                {".vbox", "application/x-virtualbox-vbox"},
                {".aspx", "application/xml"},
                {".resx", "application/xml"},
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".ppsx", "application/vnd.openxmlformats-officedocument.presentationml.slideshow"},
                {".xltx", "application/vnd.openxmlformats-officedocument.spreadsheetml.template"},
                {".dotx", "application/vnd.openxmlformats-officedocument.wordprocessingml.template"},
                {".potx", "application/vnd.openxmlformats-officedocument.presentationml.template"},
                {".pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation"},
            };
        }

        /// <summary>
        /// Return the mime type of the file
        /// </summary>
        /// <param name="path">path of the file</param>
        /// <returns>mime type</returns>
        public static string GetType(string path)
        {
            string t = "application/octet-stream";

            if (string.IsNullOrEmpty(path))
                return t;

            string p = path.Split(separator, StringSplitOptions.RemoveEmptyEntries).Last();
            int index = p.LastIndexOf('.');

            if (index > 0)
                p = p.Substring(index);

            p = p.ToLower(CultureInfo.InvariantCulture);

            if (mimetypes.TryGetValue(p, out t))
                return t;

            return "application/octet-stream";
        }

        /// <summary>
        /// Add a new mime type to the collection
        /// </summary>
        /// <param name="ext">file extension</param>
        /// <param name="type">mime type</param>
        public static void SetType(string ext, string type)
        {
            if (mimetypes.ContainsKey(ext))
                mimetypes[ext] = type;
            else
                mimetypes.Add(ext, type);
        }
    }
}