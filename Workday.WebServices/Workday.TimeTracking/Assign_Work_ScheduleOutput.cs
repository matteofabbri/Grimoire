using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.TimeTrackingService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assign_Work_ScheduleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assign_Work_Schedule_ResponseType Assign_Work_Schedule_Response;

		public Assign_Work_ScheduleOutput()
		{
		}

		public Assign_Work_ScheduleOutput(Assign_Work_Schedule_ResponseType Assign_Work_Schedule_Response)
		{
			this.Assign_Work_Schedule_Response = Assign_Work_Schedule_Response;
		}
	}
}
