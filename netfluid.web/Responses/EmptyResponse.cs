using System;

namespace Netfluid.Responses
{
    class EmptyResponse : IResponse
    {
        int status;

        public EmptyResponse(int status = StatusCode.Ok)
        {
            this.status = status;
        }

        public void Dispose()
        {
            
        }

        public void SendResponse(Context cnt)
        {
            throw new NotImplementedException();
        }

        public void SetHeaders(Context cnt)
        {
            cnt.Response.StatusCode = status;
        }
    }
}
