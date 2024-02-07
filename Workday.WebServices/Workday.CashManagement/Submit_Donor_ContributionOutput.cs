using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Donor_ContributionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Donor_Contribution_ResponseType Submit_Donor_Contribution_Response;

		public Submit_Donor_ContributionOutput()
		{
		}

		public Submit_Donor_ContributionOutput(Submit_Donor_Contribution_ResponseType Submit_Donor_Contribution_Response)
		{
			this.Submit_Donor_Contribution_Response = Submit_Donor_Contribution_Response;
		}
	}
}
