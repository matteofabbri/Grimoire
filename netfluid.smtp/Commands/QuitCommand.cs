using System;
using System.Threading;
using System.Threading.Tasks;
namespace Netfluid.Smtp
{
	class QuitCommand : SmtpCommand
	{
		public override Task ExecuteAsync(SmtpSession context, CancellationToken cancellationToken)
		{
			context.Close();
			return context.Stream.ReplyAsync(SmtpResponse.ServiceClosingTransmissionChannel, cancellationToken);
		}
	}
}
