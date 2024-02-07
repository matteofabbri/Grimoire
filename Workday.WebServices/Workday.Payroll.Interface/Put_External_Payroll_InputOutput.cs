using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_External_Payroll_InputOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_External_Payroll_Input_ResponseType Put_External_Payroll_Input_Response;

		public Put_External_Payroll_InputOutput()
		{
		}

		public Put_External_Payroll_InputOutput(Put_External_Payroll_Input_ResponseType Put_External_Payroll_Input_Response)
		{
			this.Put_External_Payroll_Input_Response = Put_External_Payroll_Input_Response;
		}
	}
}
