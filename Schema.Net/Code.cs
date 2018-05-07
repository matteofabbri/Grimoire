using System;

namespace Schema.Net
{
    [Serializable]
    public  class Code : CreativeWork
    {
        /*Link to the repository where the un-compiled, human readable code and related code is located (SVN, github, CodePlex)*/
        public  string[] codeRepository;
        /*The computer programming language.*/
        public  Thing[] programmingLanguage;
        /*Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0)*/
        public  string[] runtime;
        /*Full (compile ready) solution, code snippet, inline code, scripts, template.*/
        public  string[] sampleType;
        /*Target Operating System / Product to which the code applies.  If applies to several versions, just the product name can be used.*/
        public  SoftwareApplication[] targetProduct;
    }
}