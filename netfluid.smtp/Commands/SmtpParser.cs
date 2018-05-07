using Netfluid.SmtpMail;
using Netfluid.SmtpParser;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;

namespace Netfluid.Smtp
{
	class SmtpParser
	{
		private delegate bool TryMakeDelegate<T>(TokenEnumerator enumerator, out T found);

		internal bool TryMakeReversePath(TokenEnumerator enumerator, out MailAddress mailbox)
		{
			if (TryMake<MailAddress>(enumerator, new TryMakeDelegate<MailAddress>(TryMakePath), out mailbox))
			{
				return true;
			}
			if (enumerator.Consume(1) != new Token(TokenKind.Symbol, "<"))
			{
				return false;
			}
			if (enumerator.Consume(1) != new Token(TokenKind.Symbol, ">"))
			{
				return false;
			}
			mailbox = null;
			return true;
		}

        internal bool TryMakePath(TokenEnumerator enumerator, out MailAddress mailbox)
		{
			mailbox = null;
			string text;
			return !(enumerator.Consume(1) != new Token(TokenKind.Symbol, "<")) && (!TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeAtDomainList), out text) || !(enumerator.Consume(1) != new Token(TokenKind.Punctuation, ":"))) && TryMake<MailAddress>(enumerator, new TryMakeDelegate<MailAddress>(TryMakeMailbox), out mailbox) && enumerator.Consume(1) == new Token(TokenKind.Symbol, ">");
		}

        internal bool TryMakeAtDomainList(TokenEnumerator enumerator, out string atDomainList)
		{
			if (!TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeAtDomain), out atDomainList))
			{
				return false;
			}
			while (enumerator.Peek(0) == new Token(TokenKind.Punctuation, ","))
			{
				enumerator.Consume(1);
				string arg;
				if (!TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeAtDomain), out arg))
				{
					return false;
				}
				atDomainList += string.Format(",{0}", arg);
			}
			return true;
		}
		internal bool TryMakeAtDomain(TokenEnumerator enumerator, out string atDomain)
		{
			atDomain = null;
			if (enumerator.Consume(1) != new Token(TokenKind.Punctuation, "@"))
			{
				return false;
			}
			string arg;
			if (!TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeDomain), out arg))
			{
				return false;
			}
			atDomain = string.Format("@{0}", arg);
			return true;
		}
		internal bool TryMakeMailbox(TokenEnumerator enumerator, out MailAddress mailbox)
		{
			mailbox = null;
			string user;
			if (!TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeLocalPart), out user))
			{
				return false;
			}
			if (enumerator.Consume(1) != new Token(TokenKind.Punctuation, "@"))
			{
				return false;
			}
			string host;
			if (TryMake(enumerator, new TryMakeDelegate<string>(TryMakeDomain), out host))
			{
				mailbox = new MailAddress($"{user}@{host}");
				return true;
			}
			string host2;
			if (TryMake(enumerator, new TryMakeDelegate<string>(TryMakeAddressLiteral), out host2))
			{
				mailbox = new MailAddress($"{user}@{host2}");
				return true;
			}
			return false;
		}
		internal bool TryMakeDomain(TokenEnumerator enumerator, out string domain)
		{
			if (!TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeSubdomain), out domain))
			{
				return false;
			}
			while (enumerator.Peek(0) == new Token(TokenKind.Punctuation, "."))
			{
				enumerator.Consume(1);
				string str;
				if (!TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeSubdomain), out str))
				{
					return false;
				}
				domain += "." + str;
			}
			return true;
		}
		internal bool TryMakeSubdomain(TokenEnumerator enumerator, out string subdomain)
		{
			if (!TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeTextOrNumber), out subdomain))
			{
				return false;
			}
			string str;
			if (!TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeTextOrNumberOrHyphenString), out str))
			{
				return subdomain != null;
			}
			subdomain += str;
			return true;
		}
		internal bool TryMakeAddressLiteral(TokenEnumerator enumerator, out string address)
		{
			address = null;
			if (enumerator.Consume(1) != new Token(TokenKind.Punctuation, "["))
			{
				return false;
			}
			enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);
			if (!TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeIpv4AddressLiteral), out address))
			{
				return false;
			}
			enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);
			return !(enumerator.Consume(1) != new Token(TokenKind.Punctuation, "]")) && address != null;
		}
		internal bool TryMakeIpv4AddressLiteral(TokenEnumerator enumerator, out string address)
		{
			address = null;
			int num;
			if (!TryMake<int>(enumerator, new TryMakeDelegate<int>(TryMakeSnum), out num))
			{
				return false;
			}
			address = num.ToString(CultureInfo.InvariantCulture);
			int num2 = 0;
			while (num2 < 3 && enumerator.Peek(0) == new Token(TokenKind.Punctuation, "."))
			{
				enumerator.Consume(1);
				if (!TryMake<int>(enumerator, new TryMakeDelegate<int>(TryMakeSnum), out num))
				{
					return false;
				}
				address = address + '.' + num;
				num2++;
			}
			return true;
		}
		internal bool TryMakeSnum(TokenEnumerator enumerator, out int snum)
		{
			Token token = enumerator.Consume(1);
			return int.TryParse(token.Text, out snum) && token.Kind == TokenKind.Number && snum >= 0 && snum <= 255;
		}
		internal bool TryMakeTextOrNumberOrHyphenString(TokenEnumerator enumerator, out string textOrNumberOrHyphenString)
		{
			textOrNumberOrHyphenString = null;
			Token left = enumerator.Peek(0);
			while (left.Kind == TokenKind.Text || left.Kind == TokenKind.Number || left == new Token(TokenKind.Punctuation, "-"))
			{
				textOrNumberOrHyphenString += enumerator.Consume(1).Text;
				left = enumerator.Peek(0);
			}
			return textOrNumberOrHyphenString != null && left != new Token(TokenKind.Punctuation, "-");
		}
		internal bool TryMakeTextOrNumber(TokenEnumerator enumerator, out string textOrNumber)
		{
			Token token = enumerator.Consume(1);
			textOrNumber = token.Text;
			return token.Kind == TokenKind.Text || token.Kind == TokenKind.Number;
		}
		internal bool TryMakeLocalPart(TokenEnumerator enumerator, out string localPart)
		{
			return TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeDotString), out localPart);
		}
		internal bool TryMakeDotString(TokenEnumerator enumerator, out string dotString)
		{
			if (!TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeAtom), out dotString))
			{
				return false;
			}
			while (enumerator.Peek(0) == new Token(TokenKind.Punctuation, "."))
			{
				enumerator.Consume(1);
				string str;
				if (!TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeAtom), out str))
				{
					return true;
				}
				dotString += "." + str;
			}
			return true;
		}
		internal bool TryMakeAtom(TokenEnumerator enumerator, out string atom)
		{
			atom = null;
			string str;
			while (TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeAtext), out str))
			{
				atom += str;
			}
			return atom != null;
		}
		internal bool TryMakeAtext(TokenEnumerator enumerator, out string atext)
		{
			atext = null;
			Token token = enumerator.Consume(1);
			switch (token.Kind)
			{
			case TokenKind.Text:
			case TokenKind.Number:
				atext = token.Text;
				return true;
			case TokenKind.Symbol:
			{
				char c = token.Text[0];
				if (c <= '+')
				{
					if (c != '$' && c != '+')
					{
						break;
					}
				}
				else
				{
					if (c != '=')
					{
						switch (c)
						{
						case '^':
						case '`':
							break;
						case '_':
							return false;
						default:
							switch (c)
							{
							case '|':
							case '~':
								break;
							case '}':
								return false;
							default:
								return false;
							}
							break;
						}
					}
				}
				atext = token.Text;
				return true;
			}
			case TokenKind.Punctuation:
			{
				char c2 = token.Text[0];
				if (c2 <= '?')
				{
					switch (c2)
					{
					case '!':
					case '#':
					case '%':
					case '&':
					case '\'':
					case '*':
					case '-':
					case '/':
						break;
					case '"':
					case '$':
					case '(':
					case ')':
					case '+':
					case ',':
					case '.':
						return false;
					default:
						if (c2 != '?')
						{
							return false;
						}
						break;
					}
				}
				else
				{
					if (c2 != '_')
					{
						switch (c2)
						{
						case '{':
						case '}':
							break;
						case '|':
							return false;
						default:
							return false;
						}
					}
				}
				atext = token.Text;
				return true;
			}
			}
			return false;
		}
		internal bool TryMakeMailParameters(TokenEnumerator enumerator, out IDictionary<string, string> parameters)
		{
			parameters = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			while (enumerator.Peek(0).Kind != TokenKind.None)
			{
				KeyValuePair<string, string> item;
				if (!TryMake<KeyValuePair<string, string>>(enumerator, new TryMakeDelegate<KeyValuePair<string, string>>(TryMakeEsmtpParameter), out item))
				{
					return false;
				}
				parameters.Add(item);
				enumerator.ConsumeWhile((Token t) => t.Kind == TokenKind.Space);
			}
			return parameters.Count > 0;
		}
		internal bool TryMakeEsmtpParameter(TokenEnumerator enumerator, out KeyValuePair<string, string> parameter)
		{
			parameter = default(KeyValuePair<string, string>);
			string key;
			if (!TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeEsmtpKeyword), out key))
			{
				return false;
			}
			if (enumerator.Consume(1) != new Token(TokenKind.Symbol, "="))
			{
				return false;
			}
			string value;
			if (!TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeEsmtpValue), out value))
			{
				return false;
			}
			parameter = new KeyValuePair<string, string>(key, value);
			return true;
		}
		internal bool TryMakeEsmtpKeyword(TokenEnumerator enumerator, out string keyword)
		{
			keyword = null;
			Token left = enumerator.Peek(0);
			while (left.Kind == TokenKind.Text || left.Kind == TokenKind.Number || left == new Token(TokenKind.Punctuation, "-"))
			{
				keyword += enumerator.Consume(1).Text;
				left = enumerator.Peek(0);
			}
			return keyword != null;
		}
		internal bool TryMakeEsmtpValue(TokenEnumerator enumerator, out string value)
		{
			value = null;
			Token token = enumerator.Peek(0);
			while (token.Text.Length > 0)
			{
				if (!token.Text.ToCharArray().All((char ch) => (ch >= '!' && ch <= 'B') || (ch >= '>' && ch <= '\u007f')))
				{
					break;
				}
				value += enumerator.Consume(1).Text;
				token = enumerator.Peek(0);
			}
			return value != null;
		}
		internal bool TryMakeBase64(TokenEnumerator enumerator, out string base64)
		{
			base64 = null;
			while (enumerator.Peek(0).Kind != TokenKind.None)
			{
				string str;
				if (!TryMake<string>(enumerator, new TryMakeDelegate<string>(TryMakeBase64Chars), out str))
				{
					return false;
				}
				base64 += str;
			}
			return base64 != null && base64.Length % 4 == 0;
		}
		private static bool TryMakeBase64Chars(TokenEnumerator enumerator, out string base64Chars)
		{
			base64Chars = null;
			Token token = enumerator.Consume(1);
			switch (token.Kind)
			{
			case TokenKind.Text:
			case TokenKind.Number:
				base64Chars = token.Text;
				return true;
			case TokenKind.Symbol:
			{
				char c = token.Text[0];
				if (c == '+')
				{
					base64Chars = token.Text;
					return true;
				}
				break;
			}
			case TokenKind.Punctuation:
			{
				char c2 = token.Text[0];
				if (c2 == '/')
				{
					base64Chars = token.Text;
					return true;
				}
				break;
			}
			}
			return false;
		}
		private static bool TryMake<T>(TokenEnumerator enumerator, TryMakeDelegate<T> make, out T found)
		{
			int index = enumerator.Index;
			if (make(enumerator, out found))
			{
				return true;
			}
			enumerator.Index = index;
			return false;
		}
	}
}
