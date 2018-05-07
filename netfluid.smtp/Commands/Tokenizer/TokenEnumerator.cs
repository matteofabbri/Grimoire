using System;
using System.Collections.Generic;
using System.Linq;

namespace Netfluid.SmtpParser
{
	class TokenEnumerator
	{
		private readonly Token[] _tokens;

        public int Index { get; set; }

        public int Count
		{
			get
			{
				return Math.Max(0, _tokens.Length - Index);
			}
		}
		public TokenEnumerator(IEnumerable<Token> tokenizer)
		{
			_tokens = tokenizer.ToArray();
		}
		public TokenEnumerator(params Token[] tokens)
		{
			_tokens = tokens;
		}
		public Token Peek(int count = 0)
		{
			if (Index + count < _tokens.Length)
			{
				return _tokens[Index + count];
			}
			return Token.None;
		}
		public void ConsumeWhile(Func<Token, bool> predicate)
		{
			while (predicate(Peek(0)))
			{
				Consume(1);
			}
		}
		public Token Consume(int count = 1)
		{
			Index += count;
			return Peek(-1);
		}
		public string AsOriginalText()
		{
			return string.Concat(
				from t in _tokens
				select t.Text);
		}
	}
}
