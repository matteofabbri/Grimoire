using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class End_Academic_AppointmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Academic_Appointment_ResponseType Academic_Appointment_Response;

		public End_Academic_AppointmentOutput()
		{
		}

		public End_Academic_AppointmentOutput(Academic_Appointment_ResponseType Academic_Appointment_Response)
		{
			this.Academic_Appointment_Response = Academic_Appointment_Response;
		}
	}
}
