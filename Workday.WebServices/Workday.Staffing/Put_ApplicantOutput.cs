using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_ApplicantOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Applicant_ResponseType Put_Applicant_Response;

		public Put_ApplicantOutput()
		{
		}

		public Put_ApplicantOutput(Put_Applicant_ResponseType Put_Applicant_Response)
		{
			this.Put_Applicant_Response = Put_Applicant_Response;
		}
	}
}
