using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assess_CandidateInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assess_Candidate_RequestType Assess_Candidate_Request;

		public Assess_CandidateInput()
		{
		}

		public Assess_CandidateInput(Workday_Common_HeaderType Workday_Common_Header, Assess_Candidate_RequestType Assess_Candidate_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Assess_Candidate_Request = Assess_Candidate_Request;
		}
	}
}
