using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Revenue_Recognition_ScheduleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Revenue_Recognition_Schedule_ResponseType Submit_Revenue_Recognition_Schedule_Response;

		public Submit_Revenue_Recognition_ScheduleOutput()
		{
		}

		public Submit_Revenue_Recognition_ScheduleOutput(Submit_Revenue_Recognition_Schedule_ResponseType Submit_Revenue_Recognition_Schedule_Response)
		{
			this.Submit_Revenue_Recognition_Schedule_Response = Submit_Revenue_Recognition_Schedule_Response;
		}
	}
}
