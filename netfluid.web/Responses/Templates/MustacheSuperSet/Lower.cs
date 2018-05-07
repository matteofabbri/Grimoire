using Mustache;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Netfluid.Responses.Templates.MustacheSuperSet
{
    internal class Lower : InlineTagDefinition
    {
        public Lower()
            : base("lower")
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
            var source = arguments["object"];
            writer.Write(source.ToString().ToLowerInvariant());
        }
    }
}
