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
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace NetFluid.HTTP
{
    internal class WebInterface : IDisposable, IWebInterface
    {
        public WebInterface(IPAddress addr, int port)
        {
            Endpoint = new IPEndPoint(addr, port);
            Socket = new Socket(addr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            Socket.Bind(Endpoint);
            Socket.Listen(512);
        }

        public WebInterface(IPAddress addr, int port, X509Certificate2 certificate)
        {
            Certificate = certificate;
            Endpoint = new IPEndPoint(addr, port);
            Socket = new Socket(addr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            Socket.Bind(Endpoint);
            Socket.Listen(512);
        }

        public WebInterface(IPAddress addr, int port, string certPath)
        {
            Certificate = new X509Certificate2(certPath);
            Endpoint = new IPEndPoint(addr, port);
            Socket = new Socket(addr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            Socket.Bind(Endpoint);
            Socket.Listen(512);
        }

        #region IDisposable Members

        void IDisposable.Dispose()
        {
            Socket.Close();
        }

        #endregion

        public X509Certificate2 Certificate { get; private set; }
        public IPEndPoint Endpoint { get; private set; }
        public Socket Socket { get; private set; }

        public void Start()
        {
            Engine.Logger.Log("Starting " + (Certificate != null ? "https " : "http ") + "web interface on " + Endpoint);

            Task.Factory.StartNew(() => 
            {
                while (true)
                {
                    var s = Socket.Accept();
                    Task.Factory.StartNew(() =>
                    {
                        using (var cnt = Certificate == null ? new Context(s) : new Context(s, Certificate))
                        {
                            try
                            {
                                cnt.ReadHeaders();
                                cnt.ReadRequest();
                            }
                            catch (Exception)
                            {
                                return;
                            }

                            Engine.Serve(cnt);
                        }
                    });
                }
            });
        }
    }
}