using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Revenue_Recognition_SchedulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Revenue_Recognition_Schedules_ResponseType Get_Revenue_Recognition_Schedules_Response;

		public Get_Revenue_Recognition_SchedulesOutput()
		{
		}

		public Get_Revenue_Recognition_SchedulesOutput(Get_Revenue_Recognition_Schedules_ResponseType Get_Revenue_Recognition_Schedules_Response)
		{
			this.Get_Revenue_Recognition_Schedules_Response = Get_Revenue_Recognition_Schedules_Response;
		}
	}
}
