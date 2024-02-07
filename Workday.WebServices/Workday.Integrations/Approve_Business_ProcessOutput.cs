using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Approve_Business_ProcessOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Approve_Business_Process_ResponseType Approve_Business_Process_Response;

		public Approve_Business_ProcessOutput()
		{
		}

		public Approve_Business_ProcessOutput(Approve_Business_Process_ResponseType Approve_Business_Process_Response)
		{
			this.Approve_Business_Process_Response = Approve_Business_Process_Response;
		}
	}
}
