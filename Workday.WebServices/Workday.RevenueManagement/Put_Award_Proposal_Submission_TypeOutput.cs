using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Award_Proposal_Submission_TypeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Award_Proposal_Submission_Type_ResponseType Put_Award_Proposal_Submission_Type_Response;

		public Put_Award_Proposal_Submission_TypeOutput()
		{
		}

		public Put_Award_Proposal_Submission_TypeOutput(Put_Award_Proposal_Submission_Type_ResponseType Put_Award_Proposal_Submission_Type_Response)
		{
			this.Put_Award_Proposal_Submission_Type_Response = Put_Award_Proposal_Submission_Type_Response;
		}
	}
}
