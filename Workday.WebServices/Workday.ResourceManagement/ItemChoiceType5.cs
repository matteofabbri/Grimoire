using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType5
	{
		Billable,
		[XmlEnum("Both_Billable_and_Non-Billable")]
		Both_Billable_and_NonBillable,
		[XmlEnum("Non-Billable")]
		NonBillable
	}
}
