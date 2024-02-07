using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType8
	{
		Compensation_Matrix_Amount_Based,
		[XmlEnum("Compensation_Matrix_Non-weighted_Percent_Based")]
		Compensation_Matrix_Nonweighted_Percent_Based,
		Compensation_Matrix_Weighted_Percent_Based,
		Name
	}
}
