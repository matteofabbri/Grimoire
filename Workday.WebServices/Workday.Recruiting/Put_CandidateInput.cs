using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_CandidateInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Candidate_RequestType Put_Candidate_Request;

		public Put_CandidateInput()
		{
		}

		public Put_CandidateInput(Workday_Common_HeaderType Workday_Common_Header, Put_Candidate_RequestType Put_Candidate_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Candidate_Request = Put_Candidate_Request;
		}
	}
}
