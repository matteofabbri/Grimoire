
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
namespace Netfluid.Smtp
{
	class AuthCommand : SmtpCommand
	{
		private readonly Func<SmtpSession,string,string,bool> _userAuthenticator;
		private readonly AuthenticationMethod _method;
		private readonly string _parameter;
		private string _user;
		private string _password;

		public AuthCommand(Func<SmtpSession, string, string, bool> userAuthenticator, AuthenticationMethod method, string parameter)
		{
			_userAuthenticator = userAuthenticator;
			_method = method;
			_parameter = parameter;
		}
		public override async Task ExecuteAsync(SmtpSession context, CancellationToken cancellationToken)
		{
			switch (_method)
			{
			case AuthenticationMethod.Login:
				if (!(await TryLogin(context, cancellationToken)))
				{
					await context.Stream.ReplyAsync(SmtpResponse.AuthenticationFailed, cancellationToken).ConfigureAwait(false);
					return;
				}
				break;
			case AuthenticationMethod.Plain:
				if (!(await TryPlain(context, cancellationToken)))
				{
					await context.Stream.ReplyAsync(SmtpResponse.AuthenticationFailed, cancellationToken).ConfigureAwait(false);
					return;
				}
				break;
			}
			if (!_userAuthenticator(context, _user, _password))
			{
				await context.Stream.ReplyAsync(SmtpResponse.AuthenticationFailed, cancellationToken).ConfigureAwait(false);
			}
			else
			{
				await context.Stream.ReplyAsync(SmtpResponse.AuthenticationSuccessful, cancellationToken).ConfigureAwait(false);
			}
		}
		private async Task<bool> TryPlain(SmtpSession context, CancellationToken cancellationToken)
		{
			await context.Stream.ReplyAsync(new SmtpResponse(SmtpReplyCode.ContinueWithAuth, " "), cancellationToken).ConfigureAwait(false);
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(await context.Stream.ReadLineAsync(cancellationToken).ConfigureAwait(false)));
			Match match = Regex.Match(@string, "\0(?<user>.*)\0(?<password>.*)");
			bool result;
			if (!match.Success)
			{
				await context.Stream.ReplyAsync(SmtpResponse.AuthenticationFailed, cancellationToken).ConfigureAwait(false);
				result = false;
			}
			else
			{
				_user = match.Groups["user"].Value;
				_password = match.Groups["password"].Value;
				result = true;
			}
			return result;
		}
		private async Task<bool> TryLogin(SmtpSession context, CancellationToken cancellationToken)
		{
			await context.Stream.ReplyAsync(new SmtpResponse(SmtpReplyCode.ContinueWithAuth, "VXNlcm5hbWU6"), cancellationToken);
			_user = Encoding.UTF8.GetString(Convert.FromBase64String(await context.Stream.ReadLineAsync(cancellationToken).ConfigureAwait(false)));
			await context.Stream.ReplyAsync(new SmtpResponse(SmtpReplyCode.ContinueWithAuth, "UGFzc3dvcmQ6"), cancellationToken);
			_password = Encoding.UTF8.GetString(Convert.FromBase64String(await context.Stream.ReadLineAsync(cancellationToken).ConfigureAwait(false)));
			return true;
		}
	}
}
