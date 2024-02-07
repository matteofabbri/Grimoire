using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Eligible_EarningsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Eligible_Earnings_ResponseType Get_Eligible_Earnings_Response;

		public Get_Eligible_EarningsOutput()
		{
		}

		public Get_Eligible_EarningsOutput(Get_Eligible_Earnings_ResponseType Get_Eligible_Earnings_Response)
		{
			this.Get_Eligible_Earnings_Response = Get_Eligible_Earnings_Response;
		}
	}
}
