using Mustache;
using System.Collections.Generic;
using System.IO;

namespace Netfluid.Responses.Templates.MustacheSuperSet
{
    internal class DeCamel : InlineTagDefinition
    {
        public DeCamel() : base("decamel")
        {
        }
        protected override IEnumerable<TagParameter> GetParameters()
        {
            return new TagParameter[]
            {
                new TagParameter("object")
            };
        }
        public override void GetText(TextWriter writer, Dictionary<string, object> arguments, Scope context)
        {
            var obj = arguments["object"];

            if (obj == null) return;
            
            writer.Write(obj.ToString().RemoveCamel());
        }
    }
}
