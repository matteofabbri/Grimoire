
namespace Netfluid.Smtp
{
	class SmtpResponse
	{
		internal static readonly SmtpResponse Ok = new SmtpResponse(SmtpReplyCode.Ok, "Ok");
		internal static readonly SmtpResponse ServiceReady = new SmtpResponse(SmtpReplyCode.ServiceReady, "ready when you are");
		internal static readonly SmtpResponse MailboxUnavailable = new SmtpResponse(SmtpReplyCode.MailboxUnavailable, "mailbox unavailable");
		internal static readonly SmtpResponse MailboxNameNotAllowed = new SmtpResponse(SmtpReplyCode.MailboxNameNotAllowed, "mailbox name not allowed");
		internal static readonly SmtpResponse ServiceClosingTransmissionChannel = new SmtpResponse(SmtpReplyCode.ServiceClosingTransmissionChannel, "bye");
		internal static readonly SmtpResponse SyntaxError = new SmtpResponse(SmtpReplyCode.SyntaxError, "syntax error");
		internal static readonly SmtpResponse SizeLimitExceeded = new SmtpResponse(SmtpReplyCode.SizeLimitExceeded, "size limit exceeded");
		internal static readonly SmtpResponse NoValidRecipientsGiven = new SmtpResponse(SmtpReplyCode.TransactionFailed, "no valid recipients given");
		internal static readonly SmtpResponse AuthenticationFailed = new SmtpResponse(SmtpReplyCode.AuthenticationFailed, "authentication failed");
		internal static readonly SmtpResponse AuthenticationSuccessful = new SmtpResponse(SmtpReplyCode.AuthenticationSuccessful, "go ahead");
		internal SmtpReplyCode ReplyCode
		{
			get;
			private set;
		}
		internal string Message
		{
			get;
			private set;
		}
		internal SmtpResponse(SmtpReplyCode replyCode, string message = null)
		{
			ReplyCode = replyCode;
			Message = message;
		}
	}
}
