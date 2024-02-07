using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ApplicantsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Applicants_ResponseType Get_Applicants_Response;

		public Get_ApplicantsOutput()
		{
		}

		public Get_ApplicantsOutput(Get_Applicants_ResponseType Get_Applicants_Response)
		{
			this.Get_Applicants_Response = Get_Applicants_Response;
		}
	}
}
