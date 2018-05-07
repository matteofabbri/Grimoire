using System;
using System.Threading;
using System.Threading.Tasks;
namespace Netfluid.Smtp
{
	class RsetCommand : SmtpCommand
	{
		public override Task ExecuteAsync(SmtpSession context, CancellationToken cancellationToken)
		{
			context.Reset();
			return context.Stream.ReplyAsync(SmtpResponse.Ok, cancellationToken);
		}
	}
}
