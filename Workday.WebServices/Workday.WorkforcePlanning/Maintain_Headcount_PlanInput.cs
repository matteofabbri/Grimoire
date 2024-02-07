using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Maintain_Headcount_PlanInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Maintain_Headcount_Plan_RequestType Maintain_Headcount_Plan_Request;

		public Maintain_Headcount_PlanInput()
		{
		}

		public Maintain_Headcount_PlanInput(Workday_Common_HeaderType Workday_Common_Header, Maintain_Headcount_Plan_RequestType Maintain_Headcount_Plan_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Maintain_Headcount_Plan_Request = Maintain_Headcount_Plan_Request;
		}
	}
}
