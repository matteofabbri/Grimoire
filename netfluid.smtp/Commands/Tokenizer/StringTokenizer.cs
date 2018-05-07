
using System.Collections;
using System.Collections.Generic;

namespace Netfluid.SmtpParser
{
	class StringTokenizer : IEnumerable<Token>, IEnumerable
	{
		private readonly string _text;
		public StringTokenizer(string text)
		{
			_text = text;
		}
		public IEnumerator<Token> GetEnumerator()
		{
			for (int i = 0; i < _text.Length; i++)
			{
				if (char.IsLetter(_text[i]))
				{
					int num = i;
					while (i + 1 < _text.Length && char.IsLetterOrDigit(_text[i + 1]))
					{
						i++;
					}
					yield return new Token(TokenKind.Text, _text.Substring(num, i - num + 1));
				}
				else
				{
					if (char.IsDigit(_text[i]))
					{
						int num2 = i;
						TokenKind kind = TokenKind.Number;
						while (i + 1 < _text.Length && char.IsLetterOrDigit(_text[i + 1]))
						{
							if (char.IsLetter(_text[i + 1]))
							{
								kind = TokenKind.Text;
							}
							i++;
						}
						yield return new Token(kind, _text.Substring(num2, i - num2 + 1));
					}
					else
					{
						if (char.IsPunctuation(_text[i]))
						{
							yield return new Token(TokenKind.Punctuation, _text[i]);
						}
						else
						{
							if (char.IsSymbol(_text[i]))
							{
								yield return new Token(TokenKind.Symbol, _text[i]);
							}
							else
							{
								if (_text[i] == ' ')
								{
									yield return new Token(TokenKind.Space, " ");
								}
								else
								{
									yield return new Token(TokenKind.Other, _text[i]);
								}
							}
						}
					}
				}
			}
			yield break;
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
