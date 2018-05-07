namespace Netfluid
{
    /// <summary>
    /// Permanent redirect for clients
    /// </summary>
    public class MovedPermanentlyResponse:IResponse
    {
        /// <summary>
        /// Absolute or relative URI
        /// </summary>
        public string Destination;
        
        public void SetHeaders(Context cnt)
        {
            cnt.Response.StatusCode = (int) StatusCode.MovedPermanently;
            cnt.Response.Redirect(Destination);
            //FIXME
            //CHECK IT
        }

        public void SendResponse(Context cnt)
        {
        }

        public void Dispose()
        {
            Destination = null;
        }
    }
}
