using Mustache;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Netfluid.Responses.Templates.MustacheSuperSet
{
    class HtmlOptions : Mustache.InlineTagDefinition
    {
        public HtmlOptions() : base("options")
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
            
            var enu = source as IEnumerable;

            if (enu != null)
            {
                foreach (var item in enu)
                {
                    writer.Write("<option value=\"" + item.ToString().HTMLEncode() + "\">" + item.ToString().HTMLEncode() + "</option>");
                }
                return;
            }

            var t = source.GetType();
            if (t.IsEnum)
            {
                foreach (var item in Enum.GetValues(t))
                {
                    writer.Write("<option value=\"" + item.ToString().HTMLEncode() + "\">" + item.ToString().RemoveCamel().HTMLEncode() + "</option>");
                }
            }
        }
    }
}
