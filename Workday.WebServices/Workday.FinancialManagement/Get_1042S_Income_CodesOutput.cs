using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_1042S_Income_CodesOutput
	{
		[MessageBodyMember(Name = "Get_1042-S_Income_Codes_Response", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Get_1042-S_Income_Codes_Response")]
		public Get_1042S_Income_Codes_ResponseType Get_1042S_Income_Codes_Response;

		public Get_1042S_Income_CodesOutput()
		{
		}

		public Get_1042S_Income_CodesOutput(Get_1042S_Income_Codes_ResponseType Get_1042S_Income_Codes_Response)
		{
			this.Get_1042S_Income_Codes_Response = Get_1042S_Income_Codes_Response;
		}
	}
}
