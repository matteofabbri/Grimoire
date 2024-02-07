using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType8
	{
		[XmlEnum("Ship-To_Address_Customer_Account_Number")]
		ShipTo_Address_Customer_Account_Number,
		[XmlEnum("Ship-To_Address_Global_Location_Number")]
		ShipTo_Address_Global_Location_Number
	}
}
