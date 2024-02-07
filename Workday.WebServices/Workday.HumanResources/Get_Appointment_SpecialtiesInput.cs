using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Appointment_SpecialtiesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Appointment_Specialties_RequestType Get_Appointment_Specialties_Request;

		public Get_Appointment_SpecialtiesInput()
		{
		}

		public Get_Appointment_SpecialtiesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Appointment_Specialties_RequestType Get_Appointment_Specialties_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Appointment_Specialties_Request = Get_Appointment_Specialties_Request;
		}
	}
}
