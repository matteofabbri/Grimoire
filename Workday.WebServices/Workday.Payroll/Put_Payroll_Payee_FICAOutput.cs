using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Payroll_Payee_FICAOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Payroll_Payee_FICA_ResponseType Put_Payroll_Payee_FICA_Response;

		public Put_Payroll_Payee_FICAOutput()
		{
		}

		public Put_Payroll_Payee_FICAOutput(Put_Payroll_Payee_FICA_ResponseType Put_Payroll_Payee_FICA_Response)
		{
			this.Put_Payroll_Payee_FICA_Response = Put_Payroll_Payee_FICA_Response;
		}
	}
}
