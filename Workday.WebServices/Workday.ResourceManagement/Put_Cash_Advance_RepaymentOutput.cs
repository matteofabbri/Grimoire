using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Cash_Advance_RepaymentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Cash_Advance_Repayment_ResponseType Put_Cash_Advance_Repayment_Response;

		public Put_Cash_Advance_RepaymentOutput()
		{
		}

		public Put_Cash_Advance_RepaymentOutput(Put_Cash_Advance_Repayment_ResponseType Put_Cash_Advance_Repayment_Response)
		{
			this.Put_Cash_Advance_Repayment_Response = Put_Cash_Advance_Repayment_Response;
		}
	}
}
