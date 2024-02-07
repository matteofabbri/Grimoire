using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_PaymentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payments_ResponseType Get_Payments_Response;

		public Get_PaymentsOutput()
		{
		}

		public Get_PaymentsOutput(Get_Payments_ResponseType Get_Payments_Response)
		{
			this.Get_Payments_Response = Get_Payments_Response;
		}
	}
}
