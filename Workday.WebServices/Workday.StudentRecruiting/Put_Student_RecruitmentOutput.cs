using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_RecruitmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Recruitment_ResponseType Put_Student_Recruitment_Response;

		public Put_Student_RecruitmentOutput()
		{
		}

		public Put_Student_RecruitmentOutput(Put_Student_Recruitment_ResponseType Put_Student_Recruitment_Response)
		{
			this.Put_Student_Recruitment_Response = Put_Student_Recruitment_Response;
		}
	}
}
