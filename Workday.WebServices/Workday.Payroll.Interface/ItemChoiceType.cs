using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType
	{
		Distribution_Amount,
		Distribution_Balance,
		Distribution_Percentage
	}
}
