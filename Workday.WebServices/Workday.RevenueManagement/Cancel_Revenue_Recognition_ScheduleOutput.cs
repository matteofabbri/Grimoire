using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Revenue_Recognition_ScheduleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Revenue_Recognition_Schedule_ResponseType Cancel_Revenue_Recognition_Schedule_Response;

		public Cancel_Revenue_Recognition_ScheduleOutput()
		{
		}

		public Cancel_Revenue_Recognition_ScheduleOutput(Cancel_Revenue_Recognition_Schedule_ResponseType Cancel_Revenue_Recognition_Schedule_Response)
		{
			this.Cancel_Revenue_Recognition_Schedule_Response = Cancel_Revenue_Recognition_Schedule_Response;
		}
	}
}
