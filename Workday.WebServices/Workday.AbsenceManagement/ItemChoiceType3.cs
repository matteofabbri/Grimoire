using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType3
	{
		Individual_Target_Amount,
		Individual_Target_Percent,
		Individual_Target_Shares
	}
}
