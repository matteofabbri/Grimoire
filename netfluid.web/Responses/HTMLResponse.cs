
using System.IO;

namespace Netfluid
{
    public class HTMLResponse : IResponse
    {
        string path;
        static Collections.StringCache<string> cache;

        static HTMLResponse()
        {
            cache = new Collections.StringCache<string>();
            cache.Load = (x) => File.ReadAllText(x);
        }

        public HTMLResponse(string path)
        {
            this.path = path;
        }

        public void Dispose()
        {
            
        }

        public void SendResponse(Context cnt)
        {
            cnt.Writer.Write(cache.Get(path));
        }

        public void SetHeaders(Context cnt)
        {
            cnt.Response.ContentType = "text/html";
        }
    }
}
