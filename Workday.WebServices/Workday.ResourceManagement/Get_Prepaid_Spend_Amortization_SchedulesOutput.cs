using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Prepaid_Spend_Amortization_SchedulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Prepaid_Spend_Amortization_Schedules_ResponseType Get_Prepaid_Spend_Amortization_Schedules_Response;

		public Get_Prepaid_Spend_Amortization_SchedulesOutput()
		{
		}

		public Get_Prepaid_Spend_Amortization_SchedulesOutput(Get_Prepaid_Spend_Amortization_Schedules_ResponseType Get_Prepaid_Spend_Amortization_Schedules_Response)
		{
			this.Get_Prepaid_Spend_Amortization_Schedules_Response = Get_Prepaid_Spend_Amortization_Schedules_Response;
		}
	}
}
