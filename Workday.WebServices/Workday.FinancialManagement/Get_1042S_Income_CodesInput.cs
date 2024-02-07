using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_1042S_Income_CodesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Name = "Get_1042-S_Income_Codes_Request", Namespace = "urn:com.workday/bsvc", Order = 0), XmlElement("Get_1042-S_Income_Codes_Request")]
		public Get_1042S_Income_Codes_RequestType Get_1042S_Income_Codes_Request;

		public Get_1042S_Income_CodesInput()
		{
		}

		public Get_1042S_Income_CodesInput(Workday_Common_HeaderType Workday_Common_Header, Get_1042S_Income_Codes_RequestType Get_1042S_Income_Codes_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_1042S_Income_Codes_Request = Get_1042S_Income_Codes_Request;
		}
	}
}
