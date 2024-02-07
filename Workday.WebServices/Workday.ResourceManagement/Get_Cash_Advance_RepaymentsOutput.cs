using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Cash_Advance_RepaymentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Cash_Advance_Repayments_ResponseType Get_Cash_Advance_Repayments_Response;

		public Get_Cash_Advance_RepaymentsOutput()
		{
		}

		public Get_Cash_Advance_RepaymentsOutput(Get_Cash_Advance_Repayments_ResponseType Get_Cash_Advance_Repayments_Response)
		{
			this.Get_Cash_Advance_Repayments_Response = Get_Cash_Advance_Repayments_Response;
		}
	}
}
