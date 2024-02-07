using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class End_Academic_AppointmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public End_Academic_Appointment_RequestType End_Academic_Appointment_Request;

		public End_Academic_AppointmentInput()
		{
		}

		public End_Academic_AppointmentInput(Workday_Common_HeaderType Workday_Common_Header, End_Academic_Appointment_RequestType End_Academic_Appointment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.End_Academic_Appointment_Request = End_Academic_Appointment_Request;
		}
	}
}
