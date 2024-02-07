using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_Payee_RTIsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payroll_Payee_RTIs_ResponseType Get_Payroll_Payee_RTIs_Response;

		public Get_Payroll_Payee_RTIsOutput()
		{
		}

		public Get_Payroll_Payee_RTIsOutput(Get_Payroll_Payee_RTIs_ResponseType Get_Payroll_Payee_RTIs_Response)
		{
			this.Get_Payroll_Payee_RTIs_Response = Get_Payroll_Payee_RTIs_Response;
		}
	}
}
