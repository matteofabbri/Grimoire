using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Headcount_Plan_TemplatesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Headcount_Plan_Templates_ResponseType Get_Headcount_Plan_Templates_Response;

		public Get_Headcount_Plan_TemplatesOutput()
		{
		}

		public Get_Headcount_Plan_TemplatesOutput(Get_Headcount_Plan_Templates_ResponseType Get_Headcount_Plan_Templates_Response)
		{
			this.Get_Headcount_Plan_Templates_Response = Get_Headcount_Plan_Templates_Response;
		}
	}
}
