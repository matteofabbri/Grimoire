using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Proposal_GrantsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Proposal_Grants_ResponseType Get_Proposal_Grants_Response;

		public Get_Proposal_GrantsOutput()
		{
		}

		public Get_Proposal_GrantsOutput(Get_Proposal_Grants_ResponseType Get_Proposal_Grants_Response)
		{
			this.Get_Proposal_Grants_Response = Get_Proposal_Grants_Response;
		}
	}
}
