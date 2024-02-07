using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemsChoiceType
	{
		Filter_Boolean,
		Filter_Date,
		Filter_DateTimeZone,
		Filter_Number,
		Filter_Text,
		Filter_Time,
		Target_External_Field_Reference,
		Target_Instance_Reference
	}
}
