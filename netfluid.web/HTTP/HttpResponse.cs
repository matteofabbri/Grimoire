using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;

namespace Netfluid.HTTP
{
    public class HttpResponse : IDisposable
    {
        Stream stream;
        Context context;
        HttpListenerResponse response;

        internal HttpResponse(Context cnt, HttpListenerResponse resp)
        {
            context = cnt;
            response = resp;
            stream = resp.OutputStream;

            if (cnt.Request.ProtocolVersion > HttpVersion.Version10)
                response.SendChunked = true;
            
            /*
            var enc = cnt.Request.Headers["Accept-Encoding"];

            if (!string.IsNullOrEmpty(enc))
            {
                var encs = enc.Split(new[] { ' ',',' },StringSplitOptions.RemoveEmptyEntries);

                if (encs.Length == 0) return;

                if(encs[0]=="gzip")
                {
                    stream = new GZipStream(response.OutputStream, CompressionMode.Compress, false);
                    response.AddHeader("Content-Encoding", "gzip");
                    return;
                }
                else if (encs[0] == "deflate")
                {
                    stream = new DeflateStream(response.OutputStream, CompressionMode.Compress, false);
                    response.AddHeader("Content-Encoding", "deflate");
                    return;
                }
            }
            */
        }

        //
        // Summary:
        //     Gets or sets the System.Text.Encoding for this response's System.Net.HttpListenerResponse.OutputStream.
        //
        // Returns:
        //     An System.Text.Encoding object suitable for use with the data in the System.Net.HttpListenerResponse.OutputStream
        //     property, or null if no encoding is specified.
        public Encoding ContentEncoding { get { return response.ContentEncoding; } set { response.ContentEncoding = value; } }

        //
        // Summary:
        //     Gets or sets the number of bytes in the body data included in the response.
        //
        // Returns:
        //     The value of the response's Content-Length header.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The value specified for a set operation is less than zero.
        //
        //   T:System.InvalidOperationException:
        //     The response is already being sent.
        //
        //   T:System.ObjectDisposedException:
        //     This object is closed.
        public long ContentLength64 { get { return response.ContentLength64; } set { response.ContentLength64 = value; } }

        //
        // Summary:
        //     Gets or sets the MIME type of the content returned.
        //
        // Returns:
        //     A System.String instance that contains the text of the response's Content-Type
        //     header.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The value specified for a set operation is null.
        //
        //   T:System.ArgumentException:
        //     The value specified for a set operation is an empty string ("").
        //
        //   T:System.ObjectDisposedException:
        //     This object is closed.
        public string ContentType { get { return response.ContentType; } set { response.ContentType = value; } }

        //
        // Summary:
        //     Gets or sets the collection of cookies returned with the response.
        //
        // Returns:
        //     A System.Net.CookieCollection that contains cookies to accompany the response.
        //     The collection is empty if no cookies have been added to the response.
        public CookieCollection Cookies { get { return response.Cookies; } set { response.Cookies = value; } }

        //
        // Summary:
        //     Gets or sets the collection of header name/value pairs returned by the server.
        //
        // Returns:
        //     A System.Net.WebHeaderCollection instance that contains all the explicitly set
        //     HTTP headers to be included in the response.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Net.WebHeaderCollection instance specified for a set operation is
        //     not valid for a response.
        public WebHeaderCollection Headers { get { return response.Headers; } set { response.Headers = value; } }

        //
        // Summary:
        //     Gets or sets a value indicating whether the server requests a persistent connection.
        //
        // Returns:
        //     true if the server requests a persistent connection; otherwise, false. The default
        //     is true.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     This object is closed.
        public bool KeepAliv { get { return response.KeepAlive; } set { response.KeepAlive = value; } }

        //
        // Summary:
        //     Gets a System.IO.Stream object to which a response can be written.
        //
        // Returns:
        //     A System.IO.Stream object to which a response can be written.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     This object is closed.
        public Stream OutputStream { get { return stream; } set { stream = value; } }

        //
        // Summary:
        //     Gets or sets the HTTP version used for the response.
        //
        // Returns:
        //     A System.Version object indicating the version of HTTP used when responding to
        //     the client. Note that this property is now obsolete.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The value specified for a set operation is null.
        //
        //   T:System.ArgumentException:
        //     The value specified for a set operation does not have its System.Version.Major
        //     property set to 1 or does not have its System.Version.Minor property set to either
        //     0 or 1.
        //
        //   T:System.ObjectDisposedException:
        //     This object is closed.
        public Version ProtocolVersion { get { return response.ProtocolVersion; } set { response.ProtocolVersion = value; } }

        //
        // Summary:
        //     Gets or sets the value of the HTTP Location header in this response.
        //
        // Returns:
        //     A System.String that contains the absolute URL to be sent to the client in the
        //     Location header.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The value specified for a set operation is an empty string ("").
        //
        //   T:System.ObjectDisposedException:
        //     This object is closed.
        public string RedirectLocation { get { return response.RedirectLocation; } set { response.RedirectLocation = value; } }

        //
        // Summary:
        //     Gets or sets whether the response uses chunked transfer encoding.
        //
        // Returns:
        //     true if the response is set to use chunked transfer encoding; otherwise, false.
        //     The default is false.
        public bool SendChunked { get { return response.SendChunked; } set { response.SendChunked = value; } }

        //
        // Summary:
        //     Gets or sets the HTTP status code to be returned to the client.
        //
        // Returns:
        //     An System.Int32 value that specifies the HTTP status code for the requested resource.
        //     The default is System.Net.HttpStatusCode.OK, indicating that the server successfully
        //     processed the client's request and included the requested resource in the response
        //     body.
        //
        // Exceptions:
        //   T:System.ObjectDisposedException:
        //     This object is closed.
        //
        //   T:System.Net.ProtocolViolationException:
        //     The value specified for a set operation is not valid. Valid values are between
        //     100 and 999 inclusive.
        public int StatusCode { get { return response.StatusCode; } set { response.StatusCode = value; } }

        //
        // Summary:
        //     Gets or sets a text description of the HTTP status code returned to the client.
        //
        // Returns:
        //     The text description of the HTTP status code returned to the client. The default
        //     is the RFC 2616 description for the System.Net.HttpListenerResponse.StatusCode
        //     property value, or an empty string ("") if an RFC 2616 description does not exist.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The value specified for a set operation is null.
        //
        //   T:System.ArgumentException:
        //     The value specified for a set operation contains non-printable characters.
        public string StatusDescription { get { return response.StatusDescription; } set { response.StatusDescription = value; } }

        //
        // Summary:
        //     Closes the connection to the client without sending a response.
        public void Abort()
        {
            response.Abort();
            context.Close();
        }

        //
        // Summary:
        //     Adds the specified header and value to the HTTP headers for this response.
        //
        // Parameters:
        //   name:
        //     The name of the HTTP header to set.
        //
        //   value:
        //     The value for the name header.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     name is null or an empty string ("").
        //
        //   T:System.ArgumentException:
        //     You are not allowed to specify a value for the specified header.-or-name or value
        //     contains invalid characters.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     The length of value is greater than 65,535 characters.
        public void AddHeader(string name, string value)
        {
            response.AddHeader(name,value);
        }
       
        //
        // Summary:
        //     Adds the specified System.Net.Cookie to the collection of cookies for this response.
        //
        // Parameters:
        //   cookie:
        //     The System.Net.Cookie to add to the collection to be sent with this response
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     cookie is null.
        public void AppendCookie(Cookie cookie)
        {
            response.AppendCookie(cookie);
        }
        
        //
        // Summary:
        //     Appends a value to the specified HTTP header to be sent with this response.
        //
        // Parameters:
        //   name:
        //     The name of the HTTP header to append value to.
        //
        //   value:
        //     The value to append to the name header.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     name is null or an empty string ("").-or-You are not allowed to specify a value
        //     for the specified header.-or-name or value contains invalid characters.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     The length of value is greater than 65,535 characters.
        public void AppendHeader(string name, string value)
        {
            response.AppendHeader(name,value);
        }

        //
        // Summary:
        //     Sends the response to the client and releases the resources held by this System.Net.HttpListenerResponse
        //     instance.
        public void Close()
        {
            stream.FlushAsync().Wait();
            response.Close();
            context.Close();
        }

        //
        // Summary:
        //     Returns the specified byte array to the client and releases the resources held
        //     by this System.Net.HttpListenerResponse instance.
        //
        // Parameters:
        //   responseEntity:
        //     A System.Byte array that contains the response to send to the client.
        //
        //   willBlock:
        //     true to block execution while flushing the stream to the client; otherwise, false.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     responseEntity is null.
        //
        //   T:System.ObjectDisposedException:
        //     This object is closed.
        public void Close(byte[] responseEntity, bool willBlock)
        {
            response.Close(responseEntity,willBlock);
            context.Close();
        }

        //
        // Summary:
        //     Copies properties from the specified System.Net.HttpListenerResponse to this
        //     response.
        //
        // Parameters:
        //   templateResponse:
        //     The System.Net.HttpListenerResponse instance to copy.
        public void CopyFrom(HttpListenerResponse templateResponse)
        {
            response.CopyFrom(templateResponse);
        }

        //
        // Summary:
        //     Configures the response to redirect the client to the specified URL.
        //
        // Parameters:
        //   url:
        //     The URL that the client should use to locate the requested resource.
        public void Redirect(string url)
        {
            response.Redirect(url);
        }

        //
        // Summary:
        //     Adds or updates a System.Net.Cookie in the collection of cookies sent with this
        //     response.
        //
        // Parameters:
        //   cookie:
        //     A System.Net.Cookie for this response.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     cookie is null.
        //
        //   T:System.ArgumentException:
        //     The cookie already exists in the collection and could not be replaced.
        public void SetCookie(Cookie cookie)
        {
            response.SetCookie(cookie);
        }

        public void Dispose()
        {
            stream.FlushAsync().Wait();
            response.Close();
        }
    }
}
