using Netfluid.SmtpMail;

using System;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
namespace Netfluid.Smtp
{
	class RcptCommand : SmtpCommand
	{
		private readonly Func<SmtpSession,MailAddress,ValidationResult> _filter;
		public MailAddress Address { get; private set; }

		public RcptCommand(MailAddress address, Func<SmtpSession, MailAddress, ValidationResult> validate)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (validate == null)
			{
				throw new ArgumentNullException("filter");
			}
			Address = address;
			_filter = validate;
		}
		public override async Task ExecuteAsync(SmtpSession context, CancellationToken cancellationToken)
		{
			switch (_filter(context,Address))
			{
			case ValidationResult.Yes:
				context.To.Add(Address);
				await context.Stream.ReplyAsync(SmtpResponse.Ok, cancellationToken);
				break;
			case ValidationResult.NoTemporarily:
				await context.Stream.ReplyAsync(SmtpResponse.MailboxUnavailable, cancellationToken);
				break;
			case ValidationResult.NoPermanently:
				await context.Stream.ReplyAsync(SmtpResponse.MailboxNameNotAllowed, cancellationToken);
				break;
			default:
				throw new NotSupportedException("The Acceptance state is not supported.");
			}
		}
	}
}
