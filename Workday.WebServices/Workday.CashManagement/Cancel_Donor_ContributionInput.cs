using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Donor_ContributionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Donor_Contribution_RequestType Cancel_Donor_Contribution_Request;

		public Cancel_Donor_ContributionInput()
		{
		}

		public Cancel_Donor_ContributionInput(Workday_Common_HeaderType Workday_Common_Header, Cancel_Donor_Contribution_RequestType Cancel_Donor_Contribution_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Cancel_Donor_Contribution_Request = Cancel_Donor_Contribution_Request;
		}
	}
}
