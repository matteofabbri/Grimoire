using Mustache;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Netfluid.Responses.Templates.MustacheSuperSet
{
    internal class LocalTime : InlineTagDefinition
    {
        public LocalTime(): base("localTime")
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
            var source = (DateTime)arguments["object"];
            writer.Write(source.ToLocalTime());
        }
    }
}
