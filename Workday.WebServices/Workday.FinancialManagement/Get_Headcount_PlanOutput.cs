using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Headcount_PlanOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Headcount_Plan_ResponseType Get_Headcount_Plan_Response;

		public Get_Headcount_PlanOutput()
		{
		}

		public Get_Headcount_PlanOutput(Get_Headcount_Plan_ResponseType Get_Headcount_Plan_Response)
		{
			this.Get_Headcount_Plan_Response = Get_Headcount_Plan_Response;
		}
	}
}
