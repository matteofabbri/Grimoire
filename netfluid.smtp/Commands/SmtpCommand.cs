using System;
using System.Threading;
using System.Threading.Tasks;
namespace Netfluid.Smtp
{
	abstract class SmtpCommand
	{
		public abstract Task ExecuteAsync(SmtpSession context, CancellationToken cancellationToken);
	}
}
