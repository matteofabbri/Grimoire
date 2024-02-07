using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_CandidatesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Candidates_ResponseType Get_Candidates_Response;

		public Get_CandidatesOutput()
		{
		}

		public Get_CandidatesOutput(Get_Candidates_ResponseType Get_Candidates_Response)
		{
			this.Get_Candidates_Response = Get_Candidates_Response;
		}
	}
}
