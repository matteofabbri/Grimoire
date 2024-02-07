using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_History_PaymentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payroll_History_Payments_ResponseType Get_Payroll_History_Payments_Response;

		public Get_Payroll_History_PaymentsOutput()
		{
		}

		public Get_Payroll_History_PaymentsOutput(Get_Payroll_History_Payments_ResponseType Get_Payroll_History_Payments_Response)
		{
			this.Get_Payroll_History_Payments_Response = Get_Payroll_History_Payments_Response;
		}
	}
}
