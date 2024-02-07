using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum Item1ChoiceType2
	{
		[XmlEnum("Both_Capital_and_Non-Capital")]
		Both_Capital_and_NonCapital,
		Capital,
		[XmlEnum("Non-Capital")]
		NonCapital
	}
}
