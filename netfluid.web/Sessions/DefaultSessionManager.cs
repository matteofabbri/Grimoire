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

using Netfluid.Collections;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Netfluid.Sessions
{
    public class DefaultSessionManager : ISessionManager
    {
        Dictionary<string, object> dic;

        public DefaultSessionManager()
        {
            dic = new Dictionary<string, object>();
        }

        public int SessionDuration { get; set; }

        public void Destroy(string sessionId)
        {
            dic.Keys.Where(x => x.StartsWith(sessionId + ".")).ToArray().ForEach(x=>dic.Remove(x));
        }

        public object Get(string sessionId, string name)
        {
            object obj;
            dic.TryGetValue(sessionId+"."+name,out obj);
            return obj;
        }

        public bool HasItems(string sessionId)
        {
            return dic.Keys.Where(x => x.StartsWith(sessionId + ".")).Any();
        }

        public void Remove(string sessionId, string name)
        {
            dic.Remove(sessionId + "." + name);
        }

        public void Set(string sessionId, string name, object obj)
        {
            dic[sessionId + "." + name]= obj;
        }
    }
}