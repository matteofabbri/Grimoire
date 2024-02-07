using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Award_ProposalOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Award_Proposal_ResponseType Submit_Award_Proposal_Response;

		public Submit_Award_ProposalOutput()
		{
		}

		public Submit_Award_ProposalOutput(Submit_Award_Proposal_ResponseType Submit_Award_Proposal_Response)
		{
			this.Submit_Award_Proposal_Response = Submit_Award_Proposal_Response;
		}
	}
}
