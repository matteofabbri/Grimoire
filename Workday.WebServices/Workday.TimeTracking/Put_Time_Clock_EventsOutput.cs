using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.TimeTrackingService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Time_Clock_EventsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Time_Clock_Events_ResponseType Put_Time_Clock_Events_Response;

		public Put_Time_Clock_EventsOutput()
		{
		}

		public Put_Time_Clock_EventsOutput(Put_Time_Clock_Events_ResponseType Put_Time_Clock_Events_Response)
		{
			this.Put_Time_Clock_Events_Response = Put_Time_Clock_Events_Response;
		}
	}
}
