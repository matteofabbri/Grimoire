using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.TimeTrackingService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Time_Clock_EventsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Time_Clock_Events_RequestType Import_Time_Clock_Events_Request;

		public Import_Time_Clock_EventsInput()
		{
		}

		public Import_Time_Clock_EventsInput(Workday_Common_HeaderType Workday_Common_Header, Import_Time_Clock_Events_RequestType Import_Time_Clock_Events_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Time_Clock_Events_Request = Import_Time_Clock_Events_Request;
		}
	}
}
