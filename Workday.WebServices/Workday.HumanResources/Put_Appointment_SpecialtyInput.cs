using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Appointment_SpecialtyInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Appointment_Specialty_RequestType Put_Appointment_Specialty_Request;

		public Put_Appointment_SpecialtyInput()
		{
		}

		public Put_Appointment_SpecialtyInput(Workday_Common_HeaderType Workday_Common_Header, Put_Appointment_Specialty_RequestType Put_Appointment_Specialty_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Appointment_Specialty_Request = Put_Appointment_Specialty_Request;
		}
	}
}
