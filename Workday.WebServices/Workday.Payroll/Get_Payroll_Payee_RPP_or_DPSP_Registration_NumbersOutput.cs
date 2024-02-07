using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_ResponseType Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_Response;

		public Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersOutput()
		{
		}

		public Get_Payroll_Payee_RPP_or_DPSP_Registration_NumbersOutput(Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_ResponseType Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_Response)
		{
			this.Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_Response = Get_Payroll_Payee_RPP_or_DPSP_Registration_Numbers_Response;
		}
	}
}
