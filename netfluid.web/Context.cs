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
// Change Log: D:\PROGETTI\NetFluid\Netfluid\Context.cs
// Date           Changed By      Notes
// 23/10/2013    Matteo Fabbri      Inital coding
// ********************************************************************************************************

using System;
using System.IO;
using System.Net;
using Netfluid.HTTP;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;

namespace Netfluid
{
    /// <summary>
    ///     HTTP Context.
    ///     Contains client request, server response and current variables
    /// </summary>
    public class Context : IDisposable
    {
        private StreamReader reader;
        private StreamWriter writer;

        public HttpListenerContext HttpListernerContext { get; private set; }

        Stopwatch stopwatch;

        public decimal ElapsedTime
        {
            get { return stopwatch.ElapsedTicks / (decimal)Stopwatch.Frequency; }
        }

        public IPrincipal User { get { return HttpListernerContext.User; } }

        public event Action<Context> Closed = x => { };

        public string SessionId { get; private set; }

        public QueryValues Values { get; private set; }

        public HttpFileCollection Files { get; private set; }

        public HttpRequest Request { get; private set; }

        public HttpResponse Response { get; private set; }

        public bool IsOpen { get; private set; }

        public NetfluidHost Host { get; internal set; }

        public StreamReader Reader
        {
            get
            {
                if (reader == null) reader = new StreamReader(Request.InputStream);
                return reader;
            }
        }

        public StreamWriter Writer
        {
            get
            {
                if (writer == null) writer = new StreamWriter(Response.OutputStream,Encoding.UTF8);
                return writer;
            }
        }

        public CountryCode Country
        {
            get
            {
                CountryCode code = CountryCode.World;
                try
                {
                    var wc = new WebClient();
                    dynamic obj = JSON.Deserialize(wc.DownloadString($"http://ipinfo.io/{Request.RemoteEndPoint.Address.ToString()}/json"));
                    
                    if (!Enum.TryParse<CountryCode>(obj.country,true, out code)) code = CountryCode.World;
                }
                finally
                {
                }
                return code;
            }
        }

        public bool IsMobile
        {
            get
            {
                string u = Request.Headers["User-Agent"];
                Regex b = new Regex(@"(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                Regex v = new Regex(@"1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                return (b.IsMatch(u) || v.IsMatch(u.Substring(0, 4)));
            }
        }

        public Context(HttpListenerContext c)
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();

            HttpListernerContext = c;
            Request = new HttpRequest(c.Request);
            Response = new HttpResponse(this,c.Response);

            Values = new QueryValues();
            Files = new HttpFileCollection();
            IsOpen = true;

            var sess = c.Request.Cookies["session"];

            if (sess != null)
                SessionId = sess.Value;
            else
                SessionId = Security.UID()+Security.UID()+Security.UID();

            Response.ContentType = "text/html";
            Response.Headers["Access-Control-Allow-Origin"] = "*";


            //FIXME: valutare qualcosa di ancora piu sicuro
            sess = new Cookie("session", SessionId, "/");
            sess.Expires = DateTime.Now + TimeSpan.FromDays(1);

            c.Response.Cookies.Add(sess);

            #region GET PARAMETERS
            if(!string.IsNullOrEmpty(c.Request.Url.Query))
            {
                var parts = (c.Request.Url.Query[0] == '?' ? c.Request.Url.Query.Substring(1) : c.Request.Url.Query).Split(new[] { '&' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string s in parts)
                {
                    string[] val = s.Split(new[] { '=' });
                    int count = val.Length;
                    string k = HttpUtility.UrlDecode(val[0]);

                    switch (count)
                    {
                        case 2:
                            string v = HttpUtility.UrlDecode(val[1]);
                            Values.Add(k,v);
                            break;
                        case 1:
                            Values.Add(k,"true");
                            break;
                    }
                }
            }
            #endregion

            #region read request
            if (HttpListernerContext.Request.HttpMethod == "GET" || HttpListernerContext.Request.ContentLength64 <= 0) return;

            if (HttpListernerContext.Request.Headers["Content-Type"].StartsWith("application/x-www-form-urlencoded"))
            {
                //FIXME: Aggiungere MAX-POST-SIZE

                var r = new byte[HttpListernerContext.Request.ContentLength64];
                HttpListernerContext.Request.InputStream.Read(r, 0, r.Length);
                string str = HttpListernerContext.Request.ContentEncoding.GetString(r);

                foreach (string s in str.Split('&'))
                {
                    string[] val = s.Split(new[] { '=' });
                    int count = val.Length;
                    string k = HttpUtility.UrlDecode(val[0]);

                    switch (count)
                    {
                        case 2:
                            string v = HttpUtility.UrlDecode(val[1]);
                            Values.Add(k,v);
                            break;
                        case 1:
                            Values.Add(k,"true");
                            break;
                    }
                }
            }
            else if (HttpListernerContext.Request.Headers["Content-Type"].StartsWith("multipart/form-data; boundary="))
            {
                var b = HttpListernerContext.Request.Headers["Content-Type"].Substring("multipart/form-data; boundary=".Length);

                var parser = new MultipartFormDataParser(HttpListernerContext.Request.InputStream, b, HttpListernerContext.Request.ContentEncoding);
                parser.Parameters.ForEach(x => Values.Add( x.Key,x.Value.Data));
                parser.Files.ForEach(x => Files.Add(x));
            }
            #endregion
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Session<T>(string key, T value)
        {
            Host.Sessions.Set(SessionId, key, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Session<T>(string key)
        {
            return (T)Host.Sessions.Get(SessionId, key);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SessionDelete(string v)
        {
            Host.Sessions.Remove(SessionId, v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SessionDestroy(string v)
        {
            Host.Sessions.Destroy(SessionId);
        }

        public void Dispose()
        {
            Request.Dispose();
            Response.Dispose();

            stopwatch = null;
            HttpListernerContext = null;
            reader = null;
            writer = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void Close()
        {
            if (!IsOpen) return;

            try
            {
                IsOpen = false;
                Writer.Flush();
                Response.OutputStream.Flush();
                Response.Close();

                Closed(this);
            }
            catch (Exception)
            {
            }
        }

        public static implicit operator HttpListenerContext (Context cnt)
        {
            return cnt.HttpListernerContext;
        }
    }
}