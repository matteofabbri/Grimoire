using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Donor_ContributionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Donor_Contribution_ResponseType Cancel_Donor_Contribution_Response;

		public Cancel_Donor_ContributionOutput()
		{
		}

		public Cancel_Donor_ContributionOutput(Cancel_Donor_Contribution_ResponseType Cancel_Donor_Contribution_Response)
		{
			this.Cancel_Donor_Contribution_Response = Cancel_Donor_Contribution_Response;
		}
	}
}
