using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Netfluid
{
    /// <summary>
    /// Used to reply to the client with a dynamic run-time generated sitemap
    /// </summary>
    public class SitemapResponse:IResponse
    {
        public IEnumerable<string> URLs { get; set; }

        public SitemapResponse(IEnumerable<string> urls)
        {
            URLs = urls;
        }


        public void SetHeaders(Context cnt)
        {
            cnt.Response.ContentType = "application/xml";
        }

        public void SendResponse(Context cnt)
        {
            cnt.Writer.Write("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            cnt.Writer.Write("<urlset xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">");

            URLs.ForEach(x =>
            {
                cnt.Writer.Write("<url>");
                    cnt.Writer.Write("<loc>"+x+"</loc>");
                    cnt.Writer.Write("<lastmod>"+DateTime.Now.ToString("yyyy-MM-dd")+"</lastmod>");
                    cnt.Writer.Write("<changefreq>daily</changefreq>");
                    cnt.Writer.Write("<priority>1</priority>");
                cnt.Writer.Write("</url>");
                cnt.Writer.Flush();
            });

            cnt.Writer.Write("</urlset>");
        }

        public void Dispose()
        {
        }
    }
}
