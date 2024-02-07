using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType2
	{
		Amended_Order,
		Original_Order,
		Termination_Order
	}
}
