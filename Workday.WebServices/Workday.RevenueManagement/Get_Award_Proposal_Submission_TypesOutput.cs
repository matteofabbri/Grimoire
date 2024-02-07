using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Award_Proposal_Submission_TypesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Award_Proposal_Submission_Types_ResponseType Get_Award_Proposal_Submission_Types_Response;

		public Get_Award_Proposal_Submission_TypesOutput()
		{
		}

		public Get_Award_Proposal_Submission_TypesOutput(Get_Award_Proposal_Submission_Types_ResponseType Get_Award_Proposal_Submission_Types_Response)
		{
			this.Get_Award_Proposal_Submission_Types_Response = Get_Award_Proposal_Submission_Types_Response;
		}
	}
}
