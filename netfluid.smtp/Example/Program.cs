using Netfluid.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static SmtpServer server;

        static void Main(string[] args)
        {
            var smtp = new SmtpServer();

            smtp.ValidateFrom = (x) => Netfluid.SmtpMail.ValidationResult.Yes;

            smtp.ValidateRecipient = (session,recipient) => Netfluid.SmtpMail.ValidationResult.Yes;

            smtp.UserAuthenticator = (session, user, password) => true;

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
    }
}
