using Mustache;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NetFluid.Templates
{
    public class MustacheResponse : IResponse
    {
        FormatCompiler compiler;
        Generator generator;
        object args;

        static List<TagDefinition> customTags;

        static MustacheResponse()
        {
            customTags = new List<TagDefinition>();
        }

        public static void AddCustomTag(TagDefinition tag)
        {
            customTags.Add(tag);
        }

        public MustacheResponse(string templateFile): this(templateFile,null)
        { 
        }

        public MustacheResponse(string templateFile, object args)
        {
            compiler = new FormatCompiler();
            compiler.RemoveNewLines = false;
            this.args = args;

            customTags.ForEach(x=>compiler.RegisterTag(x,true));

            generator = compiler.Compile(File.ReadAllText(templateFile));
        }

        public void SetHeaders(Context cnt)
        {
            
        }

        public void SendResponse(Context cnt)
        {
            generator.Render(args,cnt.Writer);
        }

        public void Dispose()
        {
            compiler = null;
            generator = null;
        }
    }
}
 