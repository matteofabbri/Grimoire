using Mustache;
using Netfluid.Responses.Templates.MustacheSuperSet;
using System.Collections.Generic;
using System.IO;
using Netfluid.Collections;

namespace Netfluid
{
    /// <summary>
    /// Parse and return a Mustace template as HTTP response
    /// </summary>
    public class MustacheTemplate : IResponse
    {
        FormatCompiler compiler;
        Generator generator;
        object args;
        string templateFile;

        static List<TagDefinition> customTags;
        static StringCache<string> cache;


        static MustacheTemplate()
        {
            customTags = new List<TagDefinition>();
            customTags.Add(new DeCamel());
            customTags.Add(new Dotted());
            customTags.Add(new First());
            customTags.Add(new Include());
            customTags.Add(new LocalTime());
            customTags.Add(new Value());
            customTags.Add(new Count());
            customTags.Add(new HtmlList());
            customTags.Add(new HtmlOptions());
            customTags.Add(new Lower());

            cache = new StringCache<string>
            {
                Load = x=> 
                {
                    var str = File.ReadAllText(x);
                    //str = Encoding.UTF8.GetString(Encoding.Default.GetBytes(str));
                    return str;
                },
            };
        }

        /// <summary>
        /// Add ad user defined tag to the Mustache syntax
        /// </summary>
        /// <param name="tag"></param>
        public static void AddCustomTag(TagDefinition tag)
        {
            customTags.Add(tag);
        }

        /// <summary>
        /// Instance a new Mustache response without parameters
        /// </summary>
        /// <param name="templateFile">Path to the template</param>
        public MustacheTemplate(string templateFile)
        {
            this.templateFile = templateFile;

            if (File.Exists(templateFile))
            {
                compiler = new FormatCompiler();
                compiler.RemoveNewLines = false;
                args = null;

                customTags.ForEach(x => compiler.RegisterTag(x, true));

                generator = compiler.Compile(cache[Path.GetFullPath(templateFile)]);
            }
        }

        /// <summary>
        /// Instance a new Mustache response with object, dynamic or anonymous parameter
        /// </summary>
        /// <param name="templateFile">Path to the template</param>
        /// <param name="args">Class, struct, dynamic or anonymous object</param>
        public MustacheTemplate(string templateFile, object args)
        {
            this.templateFile = templateFile;

            if(File.Exists(templateFile))
            {
                compiler = new FormatCompiler();
                compiler.RemoveNewLines = false;
                this.args = args;

                customTags.ForEach(x => compiler.RegisterTag(x, true));

                generator = compiler.Compile(cache[Path.GetFullPath(templateFile)]);
            }
        }

        /// <summary>
        /// Used by Engine to set HTTP headers for the response
        /// </summary>
        /// <param name="cnt">Current HTTP/S context</param>
        public void SetHeaders(Context cnt)
        {
            cnt.Response.Headers.Set("Content-Type", "text/html; charset=utf-8");   
        }

        /// <summary>
        /// Used by the Engine to serialize the response and send it to the client
        /// </summary>
        /// <param name="cnt"></param>
        public void SendResponse(Context cnt)
        {
            if(generator == null)
            {
                cnt.Writer.Write(templateFile + " does not exists");
                return;
            }

            generator.Render(args,cnt.Writer);
            cnt.Writer.Flush();
        }

        /// <summary>
        /// Parse a Mustache template with arguments and return the results as a string
        /// </summary>
        /// <param name="path">Path to the tempalte</param>
        /// <param name="args">Class, struct, dynamic or anonymous object</param>
        /// <returns></returns>
        public static string FromFile(string path, object args)
        {
            var compiler = new FormatCompiler();
            compiler.RemoveNewLines = false;
            customTags.ForEach(x => compiler.RegisterTag(x, true));

            var writer = new StringWriter();
            var generator = compiler.Compile(cache[Path.GetFullPath(path)]);
            generator.Render(args, writer);

            return writer.ToString();
        }

        /// <summary>
        /// Parse a Mustache template with arguments and return the results as a string
        /// </summary>
        /// <param name="mustache"Mustache template source</param>
        /// <param name="args">Class, struct, dynamic or anonymous object</param>
        /// <returns></returns>
        public static string Parse(string mustache, object args)
        {
            var compiler = new FormatCompiler();
            compiler.RemoveNewLines = false;
            customTags.ForEach(x => compiler.RegisterTag(x, true));

            var writer = new StringWriter();
            var generator = compiler.Compile(mustache);
            generator.Render(args, writer);

            return writer.ToString();
        }

        /// <summary>
        /// Clean the memory
        /// </summary>
        public void Dispose()
        {
            compiler = null;
            generator = null;
        }
    }
}
 