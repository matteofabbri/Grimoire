using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_SpecialtiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Specialties_ResponseType Get_Specialties_Response;

		public Get_SpecialtiesOutput()
		{
		}

		public Get_SpecialtiesOutput(Get_Specialties_ResponseType Get_Specialties_Response)
		{
			this.Get_Specialties_Response = Get_Specialties_Response;
		}
	}
}
