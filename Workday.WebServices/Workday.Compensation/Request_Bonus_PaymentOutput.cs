using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Request_Bonus_PaymentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Request_Bonus_Payment_ResponseType Request_Bonus_Payment_Response;

		public Request_Bonus_PaymentOutput()
		{
		}

		public Request_Bonus_PaymentOutput(Request_Bonus_Payment_ResponseType Request_Bonus_Payment_Response)
		{
			this.Request_Bonus_Payment_Response = Request_Bonus_Payment_Response;
		}
	}
}
