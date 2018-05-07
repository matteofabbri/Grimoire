using System;
using System.Threading;
using System.Threading.Tasks;
namespace Netfluid.Smtp
{
	class HeloCommand : SmtpCommand
	{
		private readonly string _domain;
		public string Domain
		{
			get
			{
				return _domain;
			}
		}
		public HeloCommand(string domain)
		{
			_domain = domain;
		}
		public override Task ExecuteAsync(SmtpSession context, CancellationToken cancellationToken)
		{
			SmtpResponse response = new SmtpResponse(SmtpReplyCode.Ok, string.Format("Hello {0}, haven't we met before?", Domain));
			return context.Stream.ReplyAsync(response, cancellationToken);
		}
	}
}
