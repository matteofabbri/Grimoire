using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Request_for_Quote_ResponsesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Request_for_Quote_Responses_RequestType Get_Request_for_Quote_Responses_Request;

		public Get_Request_for_Quote_ResponsesInput()
		{
		}

		public Get_Request_for_Quote_ResponsesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Request_for_Quote_Responses_RequestType Get_Request_for_Quote_Responses_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Request_for_Quote_Responses_Request = Get_Request_for_Quote_Responses_Request;
		}
	}
}
