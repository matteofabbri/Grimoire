using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum Item1ChoiceType
	{
		Withholding_Order_Amount,
		Withholding_Order_Amount_as_Percent
	}
}
