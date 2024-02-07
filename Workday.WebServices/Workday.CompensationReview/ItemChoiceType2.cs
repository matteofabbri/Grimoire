using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType2
	{
		Merit_Amount,
		Merit_Increase_Percent,
		Merit_Increase_Weighted_Percent,
		Merit_New_Pay_Amount
	}
}
