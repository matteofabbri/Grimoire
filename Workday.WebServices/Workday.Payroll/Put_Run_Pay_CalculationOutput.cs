using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Run_Pay_CalculationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Run_Pay_Calculation_ResponseType Put_Run_Pay_Calculation_Response;

		public Put_Run_Pay_CalculationOutput()
		{
		}

		public Put_Run_Pay_CalculationOutput(Put_Run_Pay_Calculation_ResponseType Put_Run_Pay_Calculation_Response)
		{
			this.Put_Run_Pay_Calculation_Response = Put_Run_Pay_Calculation_Response;
		}
	}
}
