using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_External_Payroll_InputsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_External_Payroll_Inputs_ResponseType Get_External_Payroll_Inputs_Response;

		public Get_External_Payroll_InputsOutput()
		{
		}

		public Get_External_Payroll_InputsOutput(Get_External_Payroll_Inputs_ResponseType Get_External_Payroll_Inputs_Response)
		{
			this.Get_External_Payroll_Inputs_Response = Get_External_Payroll_Inputs_Response;
		}
	}
}
