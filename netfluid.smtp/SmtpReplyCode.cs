
namespace Netfluid.Smtp
{
	enum SmtpReplyCode
	{
		ServiceReady = 220,
		ServiceClosingTransmissionChannel,
		AuthenticationSuccessful = 235,
		Ok = 250,
		ContinueWithAuth = 334,
		StartMailInput = 354,
		InsufficientStorage = 452,
		ClientNotPermitted = 454,
		CommandUnrecognized = 500,
		SyntaxError,
		CommandNotImplemented,
		BadSequence,
		AuthenticationFailed = 535,
		MailboxUnavailable = 550,
		SizeLimitExceeded = 552,
		MailboxNameNotAllowed,
		TransactionFailed
	}
}
