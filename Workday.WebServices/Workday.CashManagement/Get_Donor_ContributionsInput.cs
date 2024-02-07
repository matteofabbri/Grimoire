using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Donor_ContributionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Donor_Contributions_RequestType Get_Donor_Contributions_Request;

		public Get_Donor_ContributionsInput()
		{
		}

		public Get_Donor_ContributionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Donor_Contributions_RequestType Get_Donor_Contributions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Donor_Contributions_Request = Get_Donor_Contributions_Request;
		}
	}
}
