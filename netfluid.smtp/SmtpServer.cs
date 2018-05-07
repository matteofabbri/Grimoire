using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;
using Netfluid.SmtpMail;
using System.Net.Mail;

namespace Netfluid.Smtp
{
    public class SmtpServer
	{
		private readonly TraceSwitch _logger = new TraceSwitch("SmtpServer", "The SMTP server.");

        public int MaxMessageSize { get; set; }

        public string ServerName { get; set; }

        public X509Certificate ServerCertificate { get; set; }

        public List<IPEndPoint> Endpoints { get; private set; }

        public Func<SmtpSession, string> OnMessageArrived { get; set; }

        public Func<SmtpSession, string, string, bool> UserAuthenticator { get; set; }

        public Func<MailAddress, ValidationResult> ValidateFrom { get; set; }

        public Func<SmtpSession, MailAddress, ValidationResult> ValidateRecipient { get; set; }

        public SmtpServer() : this(IPAddress.Any, 25)
        {

        }

        public SmtpServer(int port) : this(IPAddress.Any, port)
        {

        }

        public SmtpServer(IPAddress ip):this(ip,25)
        {

        }

        public SmtpServer(IPAddress ip, int port)
		{
            ValidateFrom = (from) => ValidationResult.Yes;
            UserAuthenticator = (sess,user,pass) => true;
            ValidateRecipient = (sess, to) => ValidationResult.Yes;
            OnMessageArrived = (x) =>DateTime.Now.Ticks.ToString();
            MaxMessageSize = 10 * 1024 * 1024;
            ServerName = "localhost";

            Endpoints = new List<IPEndPoint>() { new IPEndPoint(ip, port) };
		}

		public async Task StartAsync()
		{
            Trace.WriteLineIf(_logger.TraceInfo, "Starting the SMTP Server");

            await Task.WhenAll(
				from e in Endpoints
				select ListenAsync(e, CancellationToken.None)).ConfigureAwait(false);
		}

		private async Task ListenAsync(IPEndPoint endpoint, CancellationToken cancellationToken)
		{
			var tcpListener = new TcpListener(endpoint);
			tcpListener.Start();
			var sessions = new ConcurrentDictionary<Task, Task>();

			try
			{
				while (!cancellationToken.IsCancellationRequested)
				{
					cancellationToken.ThrowIfCancellationRequested();
					var tcpClient = await tcpListener.AcceptTcpClientAsync().WithCancellation(cancellationToken).ConfigureAwait(false);

					var smtpSession = new SmtpSession(this, tcpClient);
					var task = smtpSession.HandleAsync(cancellationToken).ContinueWith(delegate(Task t)
					{
						Task task2;
						sessions.TryRemove(t, out task2);
						tcpClient.Close();
					});
					sessions.TryAdd(task, task);
				}
				await Task.WhenAll(sessions.Values).ConfigureAwait(false);
			}
			finally
			{
				tcpListener.Stop();
			}
		}
    }
}
