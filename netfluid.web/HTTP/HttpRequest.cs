using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Netfluid.HTTP
{
    public class HttpRequest : IDisposable
    {
        HttpListenerRequest request;

        internal HttpRequest(HttpListenerRequest req)
        {
            request = req;
        }

        //
        // Summary:
        //     Gets the MIME types accepted by the client.
        //
        // Returns:
        //     A System.String array that contains the type names specified in the request's
        //     Accept header or null if the client request did not include an Accept header.
        public string[] AcceptTypes => request.AcceptTypes;
        //
        // Summary:
        //     Gets an error code that identifies a problem with the System.Security.Cryptography.X509Certificates.X509Certificate
        //     provided by the client.
        //
        // Returns:
        //     An System.Int32 value that contains a Windows error code.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The client certificate has not been initialized yet by a call to the System.Net.HttpListenerRequest.BeginGetClientCertificate(System.AsyncCallback,System.Object)
        //     or System.Net.HttpListenerRequest.GetClientCertificate methods-or - The operation
        //     is still in progress.
        public int ClientCertificateError => request.ClientCertificateError;
        //
        // Summary:
        //     Gets the content encoding that can be used with data sent with the request
        //
        // Returns:
        //     An System.Text.Encoding object suitable for use with the data in the System.Net.HttpListenerRequest.InputStream
        //     property.
        public Encoding ContentEncoding => request.ContentEncoding;
        //
        // Summary:
        //     Gets the length of the body data included in the request.
        //
        // Returns:
        //     The value from the request's Content-Length header. This value is -1 if the content
        //     length is not known.
        public long ContentLength64 => request.ContentLength64;
        //
        // Summary:
        //     Gets the MIME type of the body data included in the request.
        //
        // Returns:
        //     A System.String that contains the text of the request's Content-Type header.
        public string ContentType => request.ContentType;
        //
        // Summary:
        //     Gets the cookies sent with the request.
        //
        // Returns:
        //     A System.Net.CookieCollection that contains cookies that accompany the request.
        //     This property returns an empty collection if the request does not contain cookies.
        public CookieCollection Cookies => request.Cookies;
        //
        // Summary:
        //     Gets a System.Boolean value that indicates whether the request has associated
        //     body data.
        //
        // Returns:
        //     true if the request has associated body data; otherwise, false.
        public bool HasEntityBody => request.HasEntityBody;
        //
        // Summary:
        //     Gets the collection of header name/value pairs sent in the request.
        //
        // Returns:
        //     A System.Net.WebHeaderCollection that contains the HTTP headers included in the
        //     request.
        public NameValueCollection Headers => request.Headers;
        //
        // Summary:
        //     Gets the HTTP method specified by the client.
        //
        // Returns:
        //     A System.String that contains the method used in the request.
        public string HttpMethod => request.HttpMethod;
        //
        // Summary:
        //     Gets a stream that contains the body data sent by the client.
        //
        // Returns:
        //     A readable System.IO.Stream object that contains the bytes sent by the client
        //     in the body of the request. This property returns System.IO.Stream.Null if no
        //     data is sent with the request.
        public Stream InputStream => request.InputStream;
        //
        // Summary:
        //     Gets a System.Boolean value that indicates whether the client sending this request
        //     is authenticated.
        //
        // Returns:
        //     true if the client was authenticated; otherwise, false.
        public bool IsAuthenticated => request.IsAuthenticated;
        //
        // Summary:
        //     Gets a System.Boolean value that indicates whether the request is sent from the
        //     local computer.
        //
        // Returns:
        //     true if the request originated on the same computer as the System.Net.HttpListener
        //     object that provided the request; otherwise, false.
        public bool IsLocal => request.IsLocal;
        //
        // Summary:
        //     Gets a System.Boolean value that indicates whether the TCP connection used to
        //     send the request is using the Secure Sockets Layer (SSL) protocol.
        //
        // Returns:
        //     true if the TCP connection is using SSL; otherwise, false.
        public bool IsSecureConnection => request.IsSecureConnection;
        //
        // Summary:
        //     Gets a System.Boolean value that indicates whether the TCP connection was a WebSocket
        //     request.
        //
        // Returns:
        //     Returns System.Boolean.true if the TCP connection is a WebSocket request; otherwise,
        //     false.
        public bool IsWebSocketRequest => request.IsWebSocketRequest;
        //
        // Summary:
        //     Gets a System.Boolean value that indicates whether the client requests a persistent
        //     connection.
        //
        // Returns:
        //     true if the connection should be kept open; otherwise, false.
        public bool KeepAlive => request.KeepAlive;
        //
        // Summary:
        //     Get the server IP address and port number to which the request is directed.
        //
        // Returns:
        //     An System.Net.IPEndPoint that represents the IP address that the request is sent
        //     to.
        public IPEndPoint LocalEndPoint => request.LocalEndPoint;
        //
        // Summary:
        //     Gets the HTTP version used by the requesting client.
        //
        // Returns:
        //     A System.Version that identifies the client's version of HTTP.
        public Version ProtocolVersion => request.ProtocolVersion;
        //
        // Summary:
        //     Gets the query string included in the request.
        //
        // Returns:
        //     A System.Collections.Specialized.NameValueCollection object that contains the
        //     query data included in the request System.Net.HttpListenerRequest.Url.
        public NameValueCollection QueryString => request.QueryString;
        //
        // Summary:
        //     Gets the URL information (without the host and port) requested by the client.
        //
        // Returns:
        //     A System.String that contains the raw URL for this request.
        public string RawUrl => request.RawUrl;
        //
        // Summary:
        //     Gets the client IP address and port number from which the request originated.
        //
        // Returns:
        //     An System.Net.IPEndPoint that represents the IP address and port number from
        //     which the request originated.
        public IPEndPoint RemoteEndPoint => request.RemoteEndPoint;
        //
        // Summary:
        //     Gets the request identifier of the incoming HTTP request.
        //
        // Returns:
        //     A System.Guid object that contains the identifier of the HTTP request.
        public Guid RequestTraceIdentifier => request.RequestTraceIdentifier;
        //
        // Summary:
        //     Gets the Service Provider Name (SPN) that the client sent on the request.
        //
        // Returns:
        //     A System.String that contains the SPN the client sent on the request.
        public string ServiceName => request.ServiceName;
        //
        // Summary:
        //     Gets the System.Net.TransportContext for the client request.
        //
        // Returns:
        //     A System.Net.TransportContext object for the client request.
        public TransportContext TransportContext => request.TransportContext;
        //
        // Summary:
        //     Gets the System.Uri object requested by the client.
        //
        // Returns:
        //     A System.Uri object that identifies the resource requested by the client.
        public Uri Url => request.Url;
        //
        // Summary:
        //     Gets the Uniform Resource Identifier (URI) of the resource that referred the
        //     client to the server.
        //
        // Returns:
        //     A System.Uri object that contains the text of the request's System.Net.HttpRequestHeader.Referer
        //     header, or null if the header was not included in the request.
        public Uri UrlReferrer => request.UrlReferrer;
        //
        // Summary:
        //     Gets the user agent presented by the client.
        //
        // Returns:
        //     A System.String object that contains the text of the request's User-Agent header.
        public string UserAgent => request.UserAgent;
        //
        // Summary:
        //     Gets the server IP address and port number to which the request is directed.
        //
        // Returns:
        //     A System.String that contains the host address information.
        public string UserHostAddress => request.UserHostAddress;
        //
        // Summary:
        //     Gets the DNS name and, if provided, the port number specified by the client.
        //
        // Returns:
        //     A System.String value that contains the text of the request's Host header.
        public string UserHostName => request.UserHostName;
        //
        // Summary:
        //     Gets the natural languages that are preferred for the response.
        //
        // Returns:
        //     A System.String array that contains the languages specified in the request's
        //     System.Net.HttpRequestHeader.AcceptLanguage header or null if the client request
        //     did not include an System.Net.HttpRequestHeader.AcceptLanguage header.
        public string[] UserLanguages => request.UserLanguages;

        //
        // Summary:
        //     Begins an asynchronous request for the client's X.509 v.3 certificate.
        //
        // Parameters:
        //   requestCallback:
        //     An System.AsyncCallback delegate that references the method to invoke when the
        //     operation is complete.
        //
        //   state:
        //     A user-defined object that contains information about the operation. This object
        //     is passed to the callback delegate when the operation completes.
        //
        // Returns:
        //     An System.IAsyncResult that indicates the status of the operation.
        public IAsyncResult BeginGetClientCertificate(AsyncCallback requestCallback, object state)
        {
            return request.BeginGetClientCertificate(requestCallback,state);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Ends an asynchronous request for the client's X.509 v.3 certificate.
        //
        // Parameters:
        //   asyncResult:
        //     The pending request for the certificate.
        //
        // Returns:
        //     The System.IAsyncResult object that is returned when the operation started.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     asyncResult is null.
        //
        //   T:System.ArgumentException:
        //     asyncResult was not obtained by calling System.Net.HttpListenerRequest.BeginGetClientCertificate(System.AsyncCallback,System.Object)e.
        //
        //   T:System.InvalidOperationException:
        //     This method was already called for the operation identified by asyncResult.
        public X509Certificate2 EndGetClientCertificate(IAsyncResult asyncResult)
        {
            return request.EndGetClientCertificate(asyncResult);
        }
        //
        // Summary:
        //     Retrieves the client's X.509 v.3 certificate.
        //
        // Returns:
        //     A System.Security.Cryptography.X509Certificates object that contains the client's
        //     X.509 v.3 certificate.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     A call to this method to retrieve the client's X.509 v.3 certificate is in progress
        //     and therefore another call to this method cannot be made.
        public X509Certificate2 GetClientCertificate()
        {
            return request.GetClientCertificate();
        }
        //
        // Summary:
        //     Retrieves the client's X.509 v.3 certificate as an asynchronous operation.
        //
        // Returns:
        //     Returns System.Threading.Tasks.Task`1.The task object representing the asynchronous
        //     operation. The System.Threading.Tasks.Task`1.Result property on the task object
        //     returns a System.Security.Cryptography.X509Certificates object that contains
        //     the client's X.509 v.3 certificate.
        public Task<X509Certificate2> GetClientCertificateAsync()
        {
            return request.GetClientCertificateAsync();
        }
    }
}
