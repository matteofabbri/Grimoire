using Mustache;
using System.Collections.Generic;
using System.IO;

namespace Netfluid.Responses.Templates.MustacheSuperSet
{
    internal class Include : InlineTagDefinition
    {
        public Include() : base("include")
        {
        }

        protected override IEnumerable<TagParameter> GetParameters()
        {
            return new TagParameter[]
            {
                new TagParameter("path"),
                new TagParameter("args")
            };
        }

        public override void GetText(TextWriter writer, Dictionary<string, object> arguments, Scope context)
        { 
            var path = arguments["path"].ToString();
            var source = File.ReadAllText(path);
            writer.Write(MustacheTemplate.Parse(source, arguments["args"]));
        }
    }
}
