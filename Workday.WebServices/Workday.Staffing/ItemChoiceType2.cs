using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType2
	{
		Primary_Compensation_Basis,
		Primary_Compensation_Basis_Amount_Change,
		Primary_Compensation_Basis_Percent_Change
	}
}
