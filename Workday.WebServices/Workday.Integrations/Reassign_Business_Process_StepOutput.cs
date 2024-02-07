using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Reassign_Business_Process_StepOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Reassign_Business_Process_Step_ResponseType Reassign_Business_Process_Step_Response;

		public Reassign_Business_Process_StepOutput()
		{
		}

		public Reassign_Business_Process_StepOutput(Reassign_Business_Process_Step_ResponseType Reassign_Business_Process_Step_Response)
		{
			this.Reassign_Business_Process_Step_Response = Reassign_Business_Process_Step_Response;
		}
	}
}
