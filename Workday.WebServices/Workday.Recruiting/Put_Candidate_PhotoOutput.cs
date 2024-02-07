using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Candidate_PhotoOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Candidate_Photos_ResponseType Put_Candidate_Photos_Response;

		public Put_Candidate_PhotoOutput()
		{
		}

		public Put_Candidate_PhotoOutput(Put_Candidate_Photos_ResponseType Put_Candidate_Photos_Response)
		{
			this.Put_Candidate_Photos_Response = Put_Candidate_Photos_Response;
		}
	}
}
