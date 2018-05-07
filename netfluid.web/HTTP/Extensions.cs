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
using System.Linq;
using System.Net;
using System.Text;

namespace Netfluid.HTTP
{
    internal static class Extensions
    {
        internal static string Unquote(this string str)
        {
            int index = str.IndexOf('\"');
            if (index >= 0)
                str = str.Substring(index + 1);

            index = str.LastIndexOf('\"');
            if (index >= 0)
                str = str.Substring(0, index);

            return str.Trim();
        }

        public static string ToClientString(this Cookie cookie)
        {
            if (cookie == null)
                throw new ArgumentNullException("cookie");

            if (cookie.Name.Length == 0)
                return String.Empty;

            var result = new StringBuilder(64);

            if (cookie.Version > 0)
                result.Append("Version=").Append(cookie.Version).Append(";");

            result.Append(cookie.Name).Append("=").Append(cookie.Value);

            if (!string.IsNullOrEmpty(cookie.Path))
                result.Append(";Path=").Append(QuotedString(cookie, cookie.Path));

            if (!string.IsNullOrEmpty(cookie.Domain))
                result.Append(";Domain=").Append(QuotedString(cookie, cookie.Domain));

            if (!string.IsNullOrEmpty(cookie.Port))
                result.Append(";Port=").Append(cookie.Port);

            return result.ToString();
        }


        private static string QuotedString(Cookie cookie, string value)
        {
            const string schar = "()<>@,;:\\\"/[]?={} \t";
            return cookie.Version == 0 || (value.All(c => c >= 0x20 && c < 0x7f && schar.IndexOf(c) == -1))
                       ? value
                       : "\"" + value.Replace("\"", "\\\"") + "\"";
        }
    }
}