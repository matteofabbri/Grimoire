using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_History_PaymentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payroll_History_Payment_ResponseType Put_Payroll_History_Payment_Response;

		public Put_Payroll_History_PaymentOutput()
		{
		}

		public Put_Payroll_History_PaymentOutput(Put_Payroll_History_Payment_ResponseType Put_Payroll_History_Payment_Response)
		{
			this.Put_Payroll_History_Payment_Response = Put_Payroll_History_Payment_Response;
		}
	}
}
