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

namespace Netfluid.Sessions
{
    /// <summary>
    /// Hanlde user context session variables. Used to override Engine Session Manager
    /// </summary>
    public interface ISessionManager
    {
        /// <summary>
        /// Variable expiration time in seconds
        /// </summary>
        int SessionDuration { get; set; }

        /// <summary>
        /// Retrieve session variable value for the user session
        /// </summary>
        /// <param name="sessionId">user session</param>
        /// <param name="name">name of the variable</param>
        /// <returns>valueof variable</returns>
        object Get(string sessionId, string name);

        /// <summary>
        /// Set the value of a variable for a specific user session
        /// </summary>
        /// <param name="sessionId">session to access</param>
        /// <param name="name">name of the variable</param>
        /// <param name="obj">value of the variable</param>
        void Set(string sessionId, string name, object obj);

        /// <summary>
        /// Remove a value from the current session
        /// </summary>
        /// <param name="sessionId">id of the session</param>
        /// <param name="name">name of the variable to be removed</param>
        void Remove(string sessionId, string name);

        /// <summary>
        /// Destroy the whole session
        /// </summary>
        /// <param name="sessionId">id of the session</param>
        void Destroy(string sessionId);


        /// <summary>
        /// True if the current session has one item or more
        /// </summary>
        /// <param name="sessionId">id of the session</param>
        /// <returns></returns>
        bool HasItems(string sessionId);
    }
}