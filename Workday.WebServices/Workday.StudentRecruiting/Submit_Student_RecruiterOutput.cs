using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Student_RecruiterOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Student_Recruiter_ResponseType Submit_Student_Recruiter_Response;

		public Submit_Student_RecruiterOutput()
		{
		}

		public Submit_Student_RecruiterOutput(Submit_Student_Recruiter_ResponseType Submit_Student_Recruiter_Response)
		{
			this.Submit_Student_Recruiter_Response = Submit_Student_Recruiter_Response;
		}
	}
}
