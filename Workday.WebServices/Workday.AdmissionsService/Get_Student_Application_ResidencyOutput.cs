using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Admissions
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Student_Application_ResidencyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Student_Application_Residency_ResponseType Get_Student_Application_Residency_Response;

		public Get_Student_Application_ResidencyOutput()
		{
		}

		public Get_Student_Application_ResidencyOutput(Get_Student_Application_Residency_ResponseType Get_Student_Application_Residency_Response)
		{
			this.Get_Student_Application_Residency_Response = Get_Student_Application_Residency_Response;
		}
	}
}
