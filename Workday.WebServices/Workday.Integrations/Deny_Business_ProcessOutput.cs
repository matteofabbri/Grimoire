using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Deny_Business_ProcessOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Deny_Business_Process_ResponseType Deny_Business_Process_Response;

		public Deny_Business_ProcessOutput()
		{
		}

		public Deny_Business_ProcessOutput(Deny_Business_Process_ResponseType Deny_Business_Process_Response)
		{
			this.Deny_Business_Process_Response = Deny_Business_Process_Response;
		}
	}
}
