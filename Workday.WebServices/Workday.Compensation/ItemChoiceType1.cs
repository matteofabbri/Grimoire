using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType1
	{
		Amount_Change,
		New_Amount,
		Percent_Change
	}
}
