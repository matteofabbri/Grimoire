using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Move_CandidateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Move_Candidate_ResponseType Move_Candidate_Response;

		public Move_CandidateOutput()
		{
		}

		public Move_CandidateOutput(Move_Candidate_ResponseType Move_Candidate_Response)
		{
			this.Move_Candidate_Response = Move_Candidate_Response;
		}
	}
}
