using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Run_Pay_CalculationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Run_Pay_Calculation_RequestType Put_Run_Pay_Calculation_Request;

		public Put_Run_Pay_CalculationInput()
		{
		}

		public Put_Run_Pay_CalculationInput(Workday_Common_HeaderType Workday_Common_Header, Put_Run_Pay_Calculation_RequestType Put_Run_Pay_Calculation_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Run_Pay_Calculation_Request = Put_Run_Pay_Calculation_Request;
		}
	}
}
