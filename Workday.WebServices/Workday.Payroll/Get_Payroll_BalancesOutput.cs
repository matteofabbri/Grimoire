using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_BalancesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payroll_Balances_ResponseType Get_Payroll_Balances_Response;

		public Get_Payroll_BalancesOutput()
		{
		}

		public Get_Payroll_BalancesOutput(Get_Payroll_Balances_ResponseType Get_Payroll_Balances_Response)
		{
			this.Get_Payroll_Balances_Response = Get_Payroll_Balances_Response;
		}
	}
}
