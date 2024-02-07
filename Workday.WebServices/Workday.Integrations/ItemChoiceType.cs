using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType
	{
		Data_Source,
		File_Utility,
		Transformation,
		Transport_Protocol
	}
}
