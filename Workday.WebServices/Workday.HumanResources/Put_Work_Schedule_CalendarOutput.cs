using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Work_Schedule_CalendarOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Work_Schedule_Calendar_ResponseType Put_Work_Schedule_Calendar_Response;

		public Put_Work_Schedule_CalendarOutput()
		{
		}

		public Put_Work_Schedule_CalendarOutput(Put_Work_Schedule_Calendar_ResponseType Put_Work_Schedule_Calendar_Response)
		{
			this.Put_Work_Schedule_Calendar_Response = Put_Work_Schedule_Calendar_Response;
		}
	}
}
