using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_CandidateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Candidate_ResponseType Put_Candidate_Response;

		public Put_CandidateOutput()
		{
		}

		public Put_CandidateOutput(Put_Candidate_ResponseType Put_Candidate_Response)
		{
			this.Put_Candidate_Response = Put_Candidate_Response;
		}
	}
}
