using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assess_CandidateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assess_Candidate_ResponseType Assess_Candidate_Response;

		public Assess_CandidateOutput()
		{
		}

		public Assess_CandidateOutput(Assess_Candidate_ResponseType Assess_Candidate_Response)
		{
			this.Assess_Candidate_Response = Assess_Candidate_Response;
		}
	}
}
