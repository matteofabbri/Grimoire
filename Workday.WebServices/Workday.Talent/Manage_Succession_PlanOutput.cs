using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Succession_PlanOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Succession_Plan_ResponseType Manage_Succession_Plan_Response;

		public Manage_Succession_PlanOutput()
		{
		}

		public Manage_Succession_PlanOutput(Manage_Succession_Plan_ResponseType Manage_Succession_Plan_Response)
		{
			this.Manage_Succession_Plan_Response = Manage_Succession_Plan_Response;
		}
	}
}
