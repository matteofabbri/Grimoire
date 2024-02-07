using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Ad_Hoc_PaymentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Ad_hoc_Payment_ResponseType Submit_Ad_hoc_Payment_Response;

		public Submit_Ad_Hoc_PaymentOutput()
		{
		}

		public Submit_Ad_Hoc_PaymentOutput(Submit_Ad_hoc_Payment_ResponseType Submit_Ad_hoc_Payment_Response)
		{
			this.Submit_Ad_hoc_Payment_Response = Submit_Ad_hoc_Payment_Response;
		}
	}
}
