using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Benefit_JobsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Benefit_Jobs_ResponseType Change_Benefit_Jobs_Response;

		public Change_Benefit_JobsOutput()
		{
		}

		public Change_Benefit_JobsOutput(Change_Benefit_Jobs_ResponseType Change_Benefit_Jobs_Response)
		{
			this.Change_Benefit_Jobs_Response = Change_Benefit_Jobs_Response;
		}
	}
}
