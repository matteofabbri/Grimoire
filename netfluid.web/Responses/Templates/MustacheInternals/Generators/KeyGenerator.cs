using System;
using System.IO;
using System.Text;

namespace Mustache
{
    /// <summary>
    /// Substitutes a key placeholder with the textual representation of the associated object.
    /// </summary>
    internal sealed class KeyGenerator : IGenerator
    {
        private readonly string _key;
        private readonly bool _isVariable;

        /// <summary>
        /// Initializes a new instance of a KeyGenerator.
        /// </summary>
        /// <param name="key">The key to substitute with its value.</param>
        /// <param name="alignment">The alignment specifier.</param>
        /// <param name="formatting">The format specifier.</param>
        public KeyGenerator(string key, string alignment, string formatting)
        {
            if (key.StartsWith("@"))
            {
                _key = key.Substring(1);
                _isVariable = true;
            }
            else
            {
                _key = key;
                _isVariable = false;
            }
        }

        void IGenerator.GetText(Scope scope, TextWriter writer, Scope context)
        {
            object value = _isVariable ? context.Find(_key) : scope.Find(_key);
            var formattable = value as IFormattable;

            if (formattable != null)
                writer.Write(formattable.ToString(null,System.Threading.Thread.CurrentThread.CurrentCulture));
            else
                writer.Write(value);
        }
    }
}
