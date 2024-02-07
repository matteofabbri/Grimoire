using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Request_for_Quote_ResponsesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Request_for_Quote_Responses_ResponseType Get_Request_for_Quote_Responses_Response;

		public Get_Request_for_Quote_ResponsesOutput()
		{
		}

		public Get_Request_for_Quote_ResponsesOutput(Get_Request_for_Quote_Responses_ResponseType Get_Request_for_Quote_Responses_Response)
		{
			this.Get_Request_for_Quote_Responses_Response = Get_Request_for_Quote_Responses_Response;
		}
	}
}
