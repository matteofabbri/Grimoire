using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Spend_AuthorizationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Spend_Authorization_ResponseType Submit_Spend_Authorization_Response;

		public Submit_Spend_AuthorizationOutput()
		{
		}

		public Submit_Spend_AuthorizationOutput(Submit_Spend_Authorization_ResponseType Submit_Spend_Authorization_Response)
		{
			this.Submit_Spend_Authorization_Response = Submit_Spend_Authorization_Response;
		}
	}
}
