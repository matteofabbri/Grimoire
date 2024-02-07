using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Eligible_EarningsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Eligible_Earnings_ResponseType Put_Eligible_Earnings_Response;

		public Put_Eligible_EarningsOutput()
		{
		}

		public Put_Eligible_EarningsOutput(Put_Eligible_Earnings_ResponseType Put_Eligible_Earnings_Response)
		{
			this.Put_Eligible_Earnings_Response = Put_Eligible_Earnings_Response;
		}
	}
}
