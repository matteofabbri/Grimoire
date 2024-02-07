using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Refer_a_CandidateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Refer_a_Candidate_ResponseType Refer_a_Candidate_Response;

		public Refer_a_CandidateOutput()
		{
		}

		public Refer_a_CandidateOutput(Refer_a_Candidate_ResponseType Refer_a_Candidate_Response)
		{
			this.Refer_a_Candidate_Response = Refer_a_Candidate_Response;
		}
	}
}
