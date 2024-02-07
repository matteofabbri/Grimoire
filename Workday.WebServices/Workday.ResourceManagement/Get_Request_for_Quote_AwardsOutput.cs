using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Request_for_Quote_AwardsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Request_for_Quote_Awards_ResponseType Get_Request_for_Quote_Awards_Response;

		public Get_Request_for_Quote_AwardsOutput()
		{
		}

		public Get_Request_for_Quote_AwardsOutput(Get_Request_for_Quote_Awards_ResponseType Get_Request_for_Quote_Awards_Response)
		{
			this.Get_Request_for_Quote_Awards_Response = Get_Request_for_Quote_Awards_Response;
		}
	}
}
