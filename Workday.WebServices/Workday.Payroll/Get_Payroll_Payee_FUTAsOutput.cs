using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Payroll_Payee_FUTAsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Payroll_Payee_FUTAs_ResponseType Get_Payroll_Payee_FUTAs_Response;

		public Get_Payroll_Payee_FUTAsOutput()
		{
		}

		public Get_Payroll_Payee_FUTAsOutput(Get_Payroll_Payee_FUTAs_ResponseType Get_Payroll_Payee_FUTAs_Response)
		{
			this.Get_Payroll_Payee_FUTAs_Response = Get_Payroll_Payee_FUTAs_Response;
		}
	}
}
