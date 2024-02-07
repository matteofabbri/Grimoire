using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType
	{
		Fiscal_Summary_Schedule_Reference,
		Plan_by_Duration,
		Plan_by_Period
	}
}
