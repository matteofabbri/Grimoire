namespace Netfluid
{
    /// <summary>
    /// Redirect the client to a different URI
    /// </summary>
    public class RedirectResponse:IResponse
    {
        /// <summary>
        /// Target URI
        /// </summary>
        public string Uri { get; set; }

        /// <summary>
        /// Redirect the client to a different URI
        /// </summary>
        /// <param name="to">relative or absolute URI</param>
        public RedirectResponse(string to)
        {
            Uri = to;
        }

        public void SetHeaders(Context cnt)
        {
            cnt.Response.Redirect(Uri);
        }

        public void SendResponse(Context cnt)
        {
        }

        public void Dispose()
        {
            
        }
    }
}
