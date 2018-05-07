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
using System.Text.RegularExpressions;

namespace Netfluid
{
    /// <summary>
    /// Set a fixed URI on wich Netfluid Engine will map the method. If putted on class it became a prefix.
    /// Method parameters are parsed from Request.Values
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
    public class RouteAttribute : Attribute
    {
        public string Url { get; set; }

        public string Method { get; set; }

        public int Index { get; set; }

        public RouteAttribute()
        {
            this.Url = "";
            Method = null;
            Index = 99999;
        }

        public RouteAttribute(string url,string method=null, int index=99999)
        {
            this.Url = url;
            Method = method;
            Index = index;
        }

        public Regex Regex
        {
            get
            {
                var urlRegex = Url;
                var find = new Regex(":[^//]+");
                foreach (Match item in find.Matches(Url))
                {
                    urlRegex = urlRegex.Replace(item.Value, "(?<" + item.Value.Substring(1) + ">[^//]+?)");
                }
                return new Regex(urlRegex);
            }
        }
    }
}