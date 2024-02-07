using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Eligible_Earnings_OverrideInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Eligible_Earnings_Override_RequestType Import_Eligible_Earnings_Override_Request;

		public Import_Eligible_Earnings_OverrideInput()
		{
		}

		public Import_Eligible_Earnings_OverrideInput(Workday_Common_HeaderType Workday_Common_Header, Import_Eligible_Earnings_Override_RequestType Import_Eligible_Earnings_Override_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Eligible_Earnings_Override_Request = Import_Eligible_Earnings_Override_Request;
		}
	}
}
