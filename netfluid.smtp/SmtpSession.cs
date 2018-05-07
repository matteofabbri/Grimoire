
using Netfluid.SmtpParser;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Mail;
using System.IO;

namespace Netfluid.Smtp
{
	public sealed class SmtpSession
	{
		readonly SmtpServer _server;
		readonly SmtpStateMachine _stateMachine;
		private bool closed;
        StringBuilder Mime;

        internal NetworkTextStream Stream;

        public string Username { get; set; }
        public int RetryCount { get; private set; }
        public MailAddress From { get; set; }
        public List<MailAddress> To { get; set; }
        public string Content { get { return Mime.ToString(); } }

        public Stream ContentStream
        {
            get
            {
                return new MemoryStream(Encoding.UTF8.GetBytes(Content));
            }
        }

        internal SmtpSession(SmtpServer server, TcpClient tcpClient)
		{
			_server = server;
			_stateMachine = new SmtpStateMachine(_server);
			Stream = new NetworkTextStream(tcpClient);
            RetryCount = 5;
            Reset();
        }

        internal void AppendLine(string v)
        {
            Mime.AppendLine(v);
        }

        public void Reset()
        {
            From = null;
            To = new List<MailAddress>();
            Mime = new StringBuilder();
        }

        public async Task HandleAsync(CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();

            Version version = typeof(SmtpSession).Assembly.GetName().Version;
            await Stream.WriteLineAsync(string.Format("220 {0} v{1} ESMTP ready", _server.ServerName, version), cancellationToken).ConfigureAwait(false);
            await Stream.FlushAsync(cancellationToken).ConfigureAwait(false);

            while (true)
			{
				int expr_201 = RetryCount;
				RetryCount = expr_201 - 1;
				if (expr_201 <= 0 || closed)
				{
					break;
				}
				cancellationToken.ThrowIfCancellationRequested();
				string text = await Stream.ReadLineAsync(cancellationToken).ConfigureAwait(false);
				SmtpCommand smtpCommand;

				if (_stateMachine.TryAccept(new TokenEnumerator(new StringTokenizer(text)), out smtpCommand))
				{
					RetryCount = 5;
				}
				await smtpCommand.ExecuteAsync(this, cancellationToken).ConfigureAwait(false);
			}
		}

		public void Close()
		{
			closed = true;
		}
	}
}
