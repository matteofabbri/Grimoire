using Netfluid.SmtpMail;
using Netfluid.SmtpParser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Mail;

namespace Netfluid.Smtp
{
	class SmtpCommandFactory
	{
		private readonly TraceSwitch _logger = new TraceSwitch("SmtpCommandFactory", "SMTP Server Command Factory");
		private readonly SmtpServer _server;
		private readonly SmtpParser _parser;

		internal SmtpCommandFactory(SmtpServer server)
		{
			_server = server;
			_parser = new SmtpParser();
		}
		internal SmtpCommand MakeInvalid(SmtpReplyCode code, string response = "")
		{
			return new InvalidCommand(new SmtpResponse(code, response));
		}
		internal SmtpCommand MakeQuit(TokenEnumerator enumerator)
		{
			enumerator.Consume(1);
			enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);
			return enumerator.Count > 1 ? MakeInvalid(SmtpReplyCode.SyntaxError, ""):  new QuitCommand();
		}
		internal SmtpCommand MakeNoop(TokenEnumerator enumerator)
		{
			enumerator.Consume(1);
			enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);
			return enumerator.Count > 1 ? MakeInvalid(SmtpReplyCode.SyntaxError, "") : new NoopCommand();
		}
		internal SmtpCommand MakeRset(TokenEnumerator enumerator)
		{
			enumerator.Consume(1);
			enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);
			return enumerator.Count > 1 ? MakeInvalid(SmtpReplyCode.SyntaxError, ""): new RsetCommand();
		}
		internal SmtpCommand MakeHelo(TokenEnumerator enumerator)
		{
			enumerator.Consume(1);
			enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);
			string domain;
			return !_parser.TryMakeDomain(enumerator, out domain)? MakeInvalid(SmtpReplyCode.SyntaxError, "") : new HeloCommand(domain);
		}
		internal SmtpCommand MakeEhlo(TokenEnumerator enumerator)
		{
			enumerator.Consume(1);
			enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);
			string domainOrAddress;
			if (_parser.TryMakeDomain(enumerator, out domainOrAddress))
			{
				return new EhloCommand(domainOrAddress, _server);
			}
			string domainOrAddress2;
			if (_parser.TryMakeAddressLiteral(enumerator, out domainOrAddress2))
			{
				return new EhloCommand(domainOrAddress2, _server);
			}
			return MakeInvalid(SmtpReplyCode.SyntaxError, "");
		}
		internal SmtpCommand MakeMail(TokenEnumerator enumerator)
		{
			enumerator.Consume(1);
			enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);
			if (enumerator.Consume(1) != new Token(TokenKind.Text, "FROM") || enumerator.Consume(1) != new Token(TokenKind.Punctuation, ":"))
			{
				return MakeInvalid(SmtpReplyCode.SyntaxError, "missing the FROM:");
			}
			enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);

			MailAddress address;
			if (!_parser.TryMakeReversePath(enumerator, out address))
			{
				return MakeInvalid(SmtpReplyCode.SyntaxError, "");
			}
			IDictionary<string, string> parameters;
			if (!_parser.TryMakeMailParameters(enumerator, out parameters))
			{
				parameters = new Dictionary<string, string>();
			}
			return new MailCommand(address, parameters, _server.ValidateFrom, 0);
		}
		internal SmtpCommand MakeRcpt(TokenEnumerator enumerator)
		{
			enumerator.Consume(1);
			enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);
			if (enumerator.Consume(1) != new Token(TokenKind.Text, "TO") || enumerator.Consume(1) != new Token(TokenKind.Punctuation, ":"))
			{
				return MakeInvalid(SmtpReplyCode.SyntaxError, "missing the TO:");
			}
			enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);
			MailAddress address;
			return !_parser.TryMakePath(enumerator, out address) ? MakeInvalid(SmtpReplyCode.SyntaxError, ""): new RcptCommand(address, _server.ValidateRecipient);
		}
		internal SmtpCommand MakeData(TokenEnumerator enumerator)
		{
			enumerator.Consume(1);
			enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);
			return enumerator.Count > 1 ? MakeInvalid(SmtpReplyCode.SyntaxError, ""): new DataCommand(_server.OnMessageArrived);
		}
		internal SmtpCommand MakeDbug(TokenEnumerator enumerator)
		{
			enumerator.Consume(1);
			enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);
			if (enumerator.Count > 1)
			{
				return MakeInvalid(SmtpReplyCode.SyntaxError, "");
			}
			return new DbugCommand();
		}
		internal SmtpCommand MakeStartTls(TokenEnumerator enumerator)
		{
			enumerator.Consume(1);
			enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);
			if (enumerator.Count > 1)
			{
				return MakeInvalid(SmtpReplyCode.SyntaxError, "");
			}
			return new StartTlsCommand(_server.ServerCertificate);
		}
		internal SmtpCommand MakeAuth(TokenEnumerator enumerator)
		{
			enumerator.Consume(1);
			enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);
			AuthenticationMethod method;
			if (!Enum.TryParse(enumerator.Peek(0).Text, true, out method))
			{
				return MakeInvalid(SmtpReplyCode.SyntaxError, "");
			}
			enumerator.Consume(1);
			string parameter = null;
			if (enumerator.Count > 0 && !_parser.TryMakeBase64(enumerator, out parameter))
			{
				return MakeInvalid(SmtpReplyCode.SyntaxError, "");
			}
			return new AuthCommand(_server.UserAuthenticator, method, parameter);
		}
	}
}
