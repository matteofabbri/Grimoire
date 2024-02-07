using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_ResponseType Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_Response;

		public Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberOutput()
		{
		}

		public Put_Payroll_Payee_RPP_or_DPSP_Registration_NumberOutput(Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_ResponseType Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_Response)
		{
			this.Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_Response = Put_Payroll_Payee_RPP_or_DPSP_Registration_Number_Response;
		}
	}
}
