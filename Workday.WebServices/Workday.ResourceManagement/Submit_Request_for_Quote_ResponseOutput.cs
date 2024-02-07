using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Request_for_Quote_ResponseOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Request_for_Quote_Response_ResponseType Submit_Request_for_Quote_Response_Response;

		public Submit_Request_for_Quote_ResponseOutput()
		{
		}

		public Submit_Request_for_Quote_ResponseOutput(Submit_Request_for_Quote_Response_ResponseType Submit_Request_for_Quote_Response_Response)
		{
			this.Submit_Request_for_Quote_Response_Response = Submit_Request_for_Quote_Response_Response;
		}
	}
}
