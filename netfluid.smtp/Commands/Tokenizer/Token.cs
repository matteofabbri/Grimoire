using System;
using System.Diagnostics;
using System.Globalization;

namespace Netfluid.SmtpParser
{
	[DebuggerDisplay("[{Kind}] {Text}")]
	struct Token
	{
		public static readonly Token None = new Token(TokenKind.None);
		public string Text
		{
			get;
			private set;
		}
		public TokenKind Kind
		{
			get;
			private set;
		}
		private Token(TokenKind kind)
		{
			this = new Token(kind, string.Empty);
			Kind = kind;
		}
		public Token(TokenKind kind, string text)
		{
			this = default(Token);
			Text = text;
			Kind = kind;
		}
		public Token(TokenKind kind, char ch)
		{
			this = default(Token);
			Text = ch.ToString(CultureInfo.InvariantCulture);
			Kind = kind;
		}
		public bool Equals(Token other)
		{
			return string.Equals(Text, other.Text, StringComparison.InvariantCultureIgnoreCase) && Kind == other.Kind;
		}
		public override bool Equals(object obj)
		{
			return !object.ReferenceEquals(null, obj) && obj is Token && Equals((Token)obj);
		}
		public override int GetHashCode()
		{
			return ((Text != null) ? Text.GetHashCode() : 0) * 397 ^ (int)Kind;
		}
		public static bool operator ==(Token left, Token right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(Token left, Token right)
		{
			return !left.Equals(right);
		}
		public override string ToString()
		{
			return string.Format("[{0}] {1}", Kind, Text);
		}
	}
}
