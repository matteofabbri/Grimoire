using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.TimeTrackingService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Time_Clock_EventsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Time_Clock_Events_RequestType Put_Time_Clock_Events_Request;

		public Put_Time_Clock_EventsInput()
		{
		}

		public Put_Time_Clock_EventsInput(Workday_Common_HeaderType Workday_Common_Header, Put_Time_Clock_Events_RequestType Put_Time_Clock_Events_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Time_Clock_Events_Request = Put_Time_Clock_Events_Request;
		}
	}
}
