using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Netfluid.Smtp
{
	class EhloCommand : SmtpCommand
	{
		private readonly string _domainOrAddress;
		private readonly SmtpServer _server;

		public string DomainOrAddress
		{
			get
			{
				return _domainOrAddress;
			}
		}

		public EhloCommand(string domainOrAddress, SmtpServer server)
		{
			_domainOrAddress = domainOrAddress;
			_server = server;
		}

		public override async Task ExecuteAsync(SmtpSession context, CancellationToken cancellationToken)
		{
			string[] array = new string[]
			{
				DomainOrAddress
			}.Union(GetExtensions(context as SmtpSession)).ToArray<string>();
			for (int i = 0; i < array.Length - 1; i++)
			{
				await context.Stream.WriteLineAsync(string.Format("250-{0}", array[i]), cancellationToken);
			}
			await context.Stream.WriteLineAsync(string.Format("250 {0}", array[array.Length - 1]), cancellationToken);
			await context.Stream.FlushAsync(cancellationToken);
		}
		private IEnumerable<string> GetExtensions(SmtpSession session)
		{
			yield return "PIPELINING";
			if (!session.Stream.IsSecure && _server.ServerCertificate != null)
			{
				yield return "STARTTLS";
			}
			if (_server.MaxMessageSize > 0)
			{
				yield return string.Format("SIZE {0}", _server.MaxMessageSize);
			}
			if (session.Stream.IsSecure && _server.UserAuthenticator != null)
			{
				yield return "AUTH PLAIN LOGIN";
			}
			yield break;
		}
	}
}
