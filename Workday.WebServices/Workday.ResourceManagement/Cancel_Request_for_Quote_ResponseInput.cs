using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Request_for_Quote_ResponseInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Request_for_Quote_Response_RequestType Cancel_Request_for_Quote_Response_Request;

		public Cancel_Request_for_Quote_ResponseInput()
		{
		}

		public Cancel_Request_for_Quote_ResponseInput(Workday_Common_HeaderType Workday_Common_Header, Cancel_Request_for_Quote_Response_RequestType Cancel_Request_for_Quote_Response_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Cancel_Request_for_Quote_Response_Request = Cancel_Request_for_Quote_Response_Request;
		}
	}
}
