using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Recruiting_Agency_CandidateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Recruiting_Agency_Candidate__ResponseType Submit_Recruiting_Agency_Candidate__Response;

		public Submit_Recruiting_Agency_CandidateOutput()
		{
		}

		public Submit_Recruiting_Agency_CandidateOutput(Submit_Recruiting_Agency_Candidate__ResponseType Submit_Recruiting_Agency_Candidate__Response)
		{
			this.Submit_Recruiting_Agency_Candidate__Response = Submit_Recruiting_Agency_Candidate__Response;
		}
	}
}
