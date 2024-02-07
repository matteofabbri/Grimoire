using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Assess_CandidateInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Assess_Candidate_RequestType Get_Assess_Candidate_Request;

		public Get_Assess_CandidateInput()
		{
		}

		public Get_Assess_CandidateInput(Workday_Common_HeaderType Workday_Common_Header, Get_Assess_Candidate_RequestType Get_Assess_Candidate_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Assess_Candidate_Request = Get_Assess_Candidate_Request;
		}
	}
}
