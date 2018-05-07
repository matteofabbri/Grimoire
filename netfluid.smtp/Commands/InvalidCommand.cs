using System;
using System.Threading;
using System.Threading.Tasks;
namespace Netfluid.Smtp
{
	class InvalidCommand : SmtpCommand
	{
		private readonly SmtpResponse _response;
		public InvalidCommand(SmtpResponse response)
		{
			_response = response;
		}
		public override Task ExecuteAsync(SmtpSession context, CancellationToken cancellationToken)
		{
			SmtpResponse response = new SmtpResponse(_response.ReplyCode, string.Format("{0}, {1} retry(ies) remaining.", _response.Message, context.RetryCount));
			return context.Stream.ReplyAsync(response, cancellationToken);
		}
	}
}
