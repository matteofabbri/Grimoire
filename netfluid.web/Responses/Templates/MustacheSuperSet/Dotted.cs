using Mustache;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace Netfluid.Responses.Templates.MustacheSuperSet
{
    class Dotted : InlineTagDefinition
    {
        public Dotted() : base("dotted")
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

            if(source!=null)
                writer.Write(source.ToString("dd.MM.yyyy"));
        }
    }
}
