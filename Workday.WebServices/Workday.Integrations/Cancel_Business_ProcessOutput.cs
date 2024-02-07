using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Business_ProcessOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Business_Process_ResponseType Cancel_Business_Process_Response;

		public Cancel_Business_ProcessOutput()
		{
		}

		public Cancel_Business_ProcessOutput(Cancel_Business_Process_ResponseType Cancel_Business_Process_Response)
		{
			this.Cancel_Business_Process_Response = Cancel_Business_Process_Response;
		}
	}
}
