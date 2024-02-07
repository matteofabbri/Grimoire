using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Usage_Billing_RateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Usage_Billing_Rate_ResponseType Put_Usage_Billing_Rate_Response;

		public Put_Usage_Billing_RateOutput()
		{
		}

		public Put_Usage_Billing_RateOutput(Put_Usage_Billing_Rate_ResponseType Put_Usage_Billing_Rate_Response)
		{
			this.Put_Usage_Billing_Rate_Response = Put_Usage_Billing_Rate_Response;
		}
	}
}
