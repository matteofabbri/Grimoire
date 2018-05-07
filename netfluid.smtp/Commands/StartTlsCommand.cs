using System;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
namespace Netfluid.Smtp
{
	class StartTlsCommand : SmtpCommand
	{
		private readonly X509Certificate _certificate;
		public StartTlsCommand(X509Certificate certificate)
		{
			_certificate = certificate;
		}
		public override async Task ExecuteAsync(SmtpSession context, CancellationToken cancellationToken)
		{
			await context.Stream.ReplyAsync(SmtpResponse.ServiceReady, cancellationToken);
			SslStream sslStream = new SslStream(context.Stream.GetInnerStream(), true);
			await sslStream.AuthenticateAsServerAsync(_certificate, false, SslProtocols.Default, true);
			context.Stream = new NetworkTextStream(sslStream);
		}
	}
}
