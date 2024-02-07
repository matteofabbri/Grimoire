using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Candidate_PhotosOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Candidate_Photos_ResponseType Get_Candidate_Photos_Response;

		public Get_Candidate_PhotosOutput()
		{
		}

		public Get_Candidate_PhotosOutput(Get_Candidate_Photos_ResponseType Get_Candidate_Photos_Response)
		{
			this.Get_Candidate_Photos_Response = Get_Candidate_Photos_Response;
		}
	}
}
