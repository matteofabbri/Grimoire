using Netfluid.Collections;
using System;
using System.IO;

namespace Netfluid
{
    public class CDNFolder : IPublicFolder
    {
        ByteCache<string> cache;
        public string VirtualPath;
        public string RealPath;

        public CDNFolder()
        {
            cache = new ByteCache<string>();
            cache.Load = (x) => File.ReadAllBytes(x);
        }

        string UriToPath(string uri)
        {
            if (uri == "/") return uri;

            var subUrl = uri.Substring(VirtualPath.Length).Replace('/', Path.DirectorySeparatorChar);
            var fpath = Path.GetFullPath(RealPath);

            if (string.IsNullOrEmpty(subUrl) || subUrl[0] != Path.DirectorySeparatorChar)
                subUrl = Path.DirectorySeparatorChar + subUrl;

            if (fpath.EndsWith(Path.DirectorySeparatorChar))
                fpath = fpath.Substring(0, fpath.Length - 1);

            return Path.GetFullPath(fpath + subUrl);
        }

        public bool Map(Context cnt)
        {
            var path = UriToPath(cnt.Request.Url.LocalPath);

            //security check
            if (!File.Exists(path))
                return false;

            if (!path.StartsWith(Path.GetFullPath(RealPath)))
                return false;

            return true;
        }

        public bool TryGetFile(Context cnt)
        {
            if (cnt.Request.Url.LocalPath.StartsWith(VirtualPath))
            {
                var path = UriToPath(cnt.Request.Url.LocalPath);

                //security check
                if (!File.Exists(path) || !path.StartsWith(Path.GetFullPath(RealPath)))
                    return false;

                cnt.Response.ContentType = MimeTypes.GetType(path);
                cnt.Response.Headers["Expires"] = (DateTime.Now + TimeSpan.FromDays(31)).ToGMT();
                cnt.Response.Headers["ETag"] = cnt.Request.Url.GetHashCode().ToString();

                if(cnt.Request.Headers["If-Modified-Since"]!=null && cnt.Request.Headers["If-Modified-Since"] != null)
                {
                    cnt.Response.StatusCode = StatusCode.NotModified;
                    cnt.Close();
                    return true;
                }

                try
                {
                    var content = cache[path];
                    cnt.Response.OutputStream.Write(content, 0, content.Length);
                }
                finally
                {
                    cnt.Close();
                }
                return true;
            }
            return false;
        }
    }
}
