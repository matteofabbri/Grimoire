using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemsChoiceType3
	{
		Boolean,
		Business_Object_Instance_Reference,
		Currency,
		Date,
		DateTime,
		External_Field_Content,
		Numeric,
		Text
	}
}
