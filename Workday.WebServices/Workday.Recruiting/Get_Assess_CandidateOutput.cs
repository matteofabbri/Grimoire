using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Assess_CandidateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Assess_Candidate_ResponseType Get_Assess_Candidate_Response;

		public Get_Assess_CandidateOutput()
		{
		}

		public Get_Assess_CandidateOutput(Get_Assess_Candidate_ResponseType Get_Assess_Candidate_Response)
		{
			this.Get_Assess_Candidate_Response = Get_Assess_Candidate_Response;
		}
	}
}
