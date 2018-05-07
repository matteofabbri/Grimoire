using System;

namespace Schema.Net
{
    [Serializable]
    public  class AlignmentObject : Intangible
    {
        /*A category of alignment between the learning resource and the framework node. Recommended values include: 'assesses', 'teaches', 'requires', 'stringComplexity', 'readingLevel', 'educationalSubject', and 'educationLevel'.*/
        public  string[] alignmentType;
        /*The framework to which the resource being described is aligned.*/
        public  string[] educationalFramework;
        /*The description of a node in an established educational framework.*/
        public  string[] targetDescription;
        /*The name of a node in an established educational framework.*/
        public  string[] targetName;
        /*The string of a node in an established educational framework.*/
        public  string[] targetUrl;
    }
}