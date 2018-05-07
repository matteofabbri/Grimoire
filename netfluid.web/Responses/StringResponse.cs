using System.Collections.Generic;

namespace Netfluid
{
    public class StringResponse : IResponse
    {
        public StringResponse(string p)
        {
            String = p;
        }

        public StringResponse(object p)
        {
            this.String = p.ToString();
        }

        public string String { get; set; }

        public void SetHeaders(Context cnt)
        {
        }

        public void SendResponse(Context cnt)
        {
            cnt.Writer.Write(String);
        }

        public void Dispose()
        {
           
        }
    }
}