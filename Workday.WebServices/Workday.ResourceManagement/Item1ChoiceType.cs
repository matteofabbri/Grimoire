using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum Item1ChoiceType
	{
		Text_for_Default_Supplier_Payment_Memo,
		Use_Invoice_Memo_as_Default_Supplier_Payment_Memo,
		Use_Supplier_Connection_Memo,
		Use_Supplier_Reference_as_Default_Supplier_Payment_Memo
	}
}
