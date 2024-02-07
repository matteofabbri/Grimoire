using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Maintain_Headcount_PlanOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Maintain_Headcount_Plan_ResponseType Maintain_Headcount_Plan_Response;

		public Maintain_Headcount_PlanOutput()
		{
		}

		public Maintain_Headcount_PlanOutput(Maintain_Headcount_Plan_ResponseType Maintain_Headcount_Plan_Response)
		{
			this.Maintain_Headcount_Plan_Response = Maintain_Headcount_Plan_Response;
		}
	}
}
