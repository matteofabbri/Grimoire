using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemChoiceType2
	{
		Keep_Debit_Credit_and_Reverse_Sign,
		Reverse_Debit_Credit
	}
}
