using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.TimeTrackingService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assign_Work_ScheduleInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assign_Work_Schedule_RequestType Assign_Work_Schedule_Request;

		public Assign_Work_ScheduleInput()
		{
		}

		public Assign_Work_ScheduleInput(Workday_Common_HeaderType Workday_Common_Header, Assign_Work_Schedule_RequestType Assign_Work_Schedule_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Assign_Work_Schedule_Request = Assign_Work_Schedule_Request;
		}
	}
}
