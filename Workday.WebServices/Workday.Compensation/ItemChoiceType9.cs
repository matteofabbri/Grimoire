using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType9
	{
		Grant_Amount,
		Grant_Percent,
		Shares_Granted
	}
}
