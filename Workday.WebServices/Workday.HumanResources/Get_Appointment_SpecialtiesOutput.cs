using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Appointment_SpecialtiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Appointment_Specialties_ResponseType Get_Appointment_Specialties_Response;

		public Get_Appointment_SpecialtiesOutput()
		{
		}

		public Get_Appointment_SpecialtiesOutput(Get_Appointment_Specialties_ResponseType Get_Appointment_Specialties_Response)
		{
			this.Get_Appointment_Specialties_Response = Get_Appointment_Specialties_Response;
		}
	}
}
