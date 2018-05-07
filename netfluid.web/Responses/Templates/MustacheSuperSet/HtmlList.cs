using Mustache;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Netfluid.Responses.Templates.MustacheSuperSet
{
    internal class HtmlList : InlineTagDefinition
    {
        public HtmlList(): base("li")
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

            if (source == null) return;

            writer.Write("<ul>");
            foreach (var item in source)
            {
                writer.Write("<li>"+item+"</li>");
            }
            writer.Write("</ul>");
        }
    }
}
