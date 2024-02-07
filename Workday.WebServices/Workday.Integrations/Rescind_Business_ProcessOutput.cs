using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Rescind_Business_ProcessOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Rescind_Business_Process_ResponseType Rescind_Business_Process_Response;

		public Rescind_Business_ProcessOutput()
		{
		}

		public Rescind_Business_ProcessOutput(Rescind_Business_Process_ResponseType Rescind_Business_Process_Response)
		{
			this.Rescind_Business_Process_Response = Rescind_Business_Process_Response;
		}
	}
}
