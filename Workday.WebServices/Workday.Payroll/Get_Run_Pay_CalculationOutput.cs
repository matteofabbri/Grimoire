using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Run_Pay_CalculationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Run_Pay_Calculation_ResponseType Get_Run_Pay_Calculation_Response;

		public Get_Run_Pay_CalculationOutput()
		{
		}

		public Get_Run_Pay_CalculationOutput(Get_Run_Pay_Calculation_ResponseType Get_Run_Pay_Calculation_Response)
		{
			this.Get_Run_Pay_Calculation_Response = Get_Run_Pay_Calculation_Response;
		}
	}
}
