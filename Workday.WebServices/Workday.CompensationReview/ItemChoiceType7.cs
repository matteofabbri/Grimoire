using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType7
	{
		Stock_Amount,
		Stock_Factor_Percent,
		Stock_Percent,
		Stock_Units
	}
}
