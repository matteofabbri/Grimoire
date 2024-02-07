using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Payroll_InputOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Payroll_Input_ResponseType Submit_Payroll_Input_Response;

		public Submit_Payroll_InputOutput()
		{
		}

		public Submit_Payroll_InputOutput(Submit_Payroll_Input_ResponseType Submit_Payroll_Input_Response)
		{
			this.Submit_Payroll_Input_Response = Submit_Payroll_Input_Response;
		}
	}
}
