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
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Netfluid
{
    /// <summary>
    /// Multipart forma data files uploaded by the client
    /// </summary>
    [Serializable]
    public class HttpFileCollection : List<HttpFile>, IDisposable
    {
        /// <summary>
        /// Get or set file from the POST variable name (it can an array)
        /// </summary>
        /// <param name="name">POST name of file (different from file name)</param>
        /// <returns></returns>
        public IEnumerable<HttpFile> this[string name]
        {
            get { return this.Where(x => x.Name == name); }
            set
            {
                this.RemoveAll(x => x.Name == name);
                this.AddRange(value);
            }
        }

        /// <summary>
        /// True if contains a file with that POST variable name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Contains(string name)
        {
            return this.Any(x => x.Name == name);
        }

        /// <summary>
        /// Take just one file with that POST variable name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public HttpFile Take(string name)
        {
            return this.FirstOrDefault(x => x.Name == name);
        }

        public void Dispose()
        {
            base.Clear();
        }
    }
}