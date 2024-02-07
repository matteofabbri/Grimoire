using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Eligible_EarningsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Eligible_Earnings_RequestType Put_Eligible_Earnings_Request;

		public Put_Eligible_EarningsInput()
		{
		}

		public Put_Eligible_EarningsInput(Workday_Common_HeaderType Workday_Common_Header, Put_Eligible_Earnings_RequestType Put_Eligible_Earnings_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Eligible_Earnings_Request = Put_Eligible_Earnings_Request;
		}
	}
}
