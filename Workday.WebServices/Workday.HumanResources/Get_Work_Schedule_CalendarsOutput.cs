using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Work_Schedule_CalendarsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Work_Schedule_Calendars_ResponseType Get_Work_Schedule_Calendars_Response;

		public Get_Work_Schedule_CalendarsOutput()
		{
		}

		public Get_Work_Schedule_CalendarsOutput(Get_Work_Schedule_Calendars_ResponseType Get_Work_Schedule_Calendars_Response)
		{
			this.Get_Work_Schedule_Calendars_Response = Get_Work_Schedule_Calendars_Response;
		}
	}
}
