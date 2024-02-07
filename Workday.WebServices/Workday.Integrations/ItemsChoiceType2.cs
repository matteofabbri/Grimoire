using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), XmlType(Namespace = "urn:com.workday/bsvc", IncludeInSchema = false)]
	[Serializable]
	public enum ItemsChoiceType2
	{
		Business_Process_Type_Excluded_From_Subscription_Reference,
		Specific_Transaction_Type_for_Suscription_Reference,
		Subscribe_to_all_Business_Processes,
		Subscribe_to_all_Transaction_Types,
		Transaction_Log_Type_Excluded_from_Subscription_Reference
	}
}
