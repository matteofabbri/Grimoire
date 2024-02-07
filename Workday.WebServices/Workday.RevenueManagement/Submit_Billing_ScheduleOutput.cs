using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Billing_ScheduleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Billing_Schedule_ResponseType Submit_Billing_Schedule_Response;

		public Submit_Billing_ScheduleOutput()
		{
		}

		public Submit_Billing_ScheduleOutput(Submit_Billing_Schedule_ResponseType Submit_Billing_Schedule_Response)
		{
			this.Submit_Billing_Schedule_Response = Submit_Billing_Schedule_Response;
		}
	}
}
