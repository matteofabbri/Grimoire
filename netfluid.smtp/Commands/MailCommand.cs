using Netfluid.SmtpMail;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
namespace Netfluid.Smtp
{
	class MailCommand : SmtpCommand
	{
		private readonly MailAddress _address;
		private readonly IDictionary<string, string> _parameters;
		private readonly Func<MailAddress,ValidationResult> _filter;
		private readonly int _maxMessageSize;
		public MailAddress Address
		{
			get
			{
				return _address;
			}
		}
		public MailCommand(MailAddress address, IDictionary<string, string> parameters, Func<MailAddress, ValidationResult> filter, int maxMessageSize = 0)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (filter == null)
			{
				throw new ArgumentNullException("filter");
			}
			_address = address;
			_parameters = parameters;
			_filter = filter;
			_maxMessageSize = maxMessageSize;
		}
		public override async Task ExecuteAsync(SmtpSession context, CancellationToken cancellationToken)
		{
			context.Reset();
			int messageSize = GetMessageSize();
			if (_maxMessageSize > 0 && messageSize > _maxMessageSize)
			{
				await context.Stream.ReplyAsync(SmtpResponse.SizeLimitExceeded, cancellationToken);
                return;
			}

            switch (_filter(Address))
            {
                case ValidationResult.Yes:
                    context.From = Address;
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
		private int GetMessageSize()
		{
			string s;
			if (!_parameters.TryGetValue("SIZE", out s))
			{
				return 0;
			}
			int result;
			if (!int.TryParse(s, out result))
			{
				return 0;
			}
			return result;
		}
	}
}
