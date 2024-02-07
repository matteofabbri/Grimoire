using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Request_for_Quote_ResponseOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Request_for_Quote_Response_ResponseType Cancel_Request_for_Quote_Response_Response;

		public Cancel_Request_for_Quote_ResponseOutput()
		{
		}

		public Cancel_Request_for_Quote_ResponseOutput(Cancel_Request_for_Quote_Response_ResponseType Cancel_Request_for_Quote_Response_Response)
		{
			this.Cancel_Request_for_Quote_Response_Response = Cancel_Request_for_Quote_Response_Response;
		}
	}
}
