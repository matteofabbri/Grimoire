# netfluid.smtp
Embeddable SMTP inbound connector

Full support for user authentication and SSL server certificate.
Expose different function to be connected inside your application.


```
    class Program
    {
        static SmtpServer server;

        static void Main(string[] args)
        {
            var smtp = new SmtpServer();

            //Change this to validate the sender (OPTIONAL)
            smtp.ValidateFrom = (x) => Netfluid.SmtpMail.ValidationResult.Yes;

            //Change this to validate each recipient (OPTIONAL)
            smtp.ValidateRecipient = (session,recipient) => Netfluid.SmtpMail.ValidationResult.Yes;

            //Implement username and password authentication (OPTIONAL)
            smtp.UserAuthenticator = (session, user, password) => true;

            Invoked every time a new message is arrived and the client ended the session
            smtp.OnMessageArrived = OnMessageArrived;

            smtp.StartAsync().Wait();

            Console.ReadLine();
        }

        private static string OnMessageArrived(SmtpSession session)
        {
            var mime = MimeKit.MimeMessage.Load(session.ContentStream);

            Console.WriteLine(mime.TextBody);

            return "OK";
        }

```
