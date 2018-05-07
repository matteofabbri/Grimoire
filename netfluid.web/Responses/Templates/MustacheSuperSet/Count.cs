using Mustache;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Netfluid.Responses.Templates.MustacheSuperSet
{
    internal class Count : InlineTagDefinition
    {
        public Count()
            : base("count")
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
            var source = arguments["object"] as IEnumerable;
            int count = 0;
            foreach (var item in source)
            {
                count++;
            }
            writer.Write(count);
        }
    }
}
