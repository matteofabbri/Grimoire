using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Run_Pay_CalculationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Run_Pay_Calculation_RequestType Get_Run_Pay_Calculation_Request;

		public Get_Run_Pay_CalculationInput()
		{
		}

		public Get_Run_Pay_CalculationInput(Workday_Common_HeaderType Workday_Common_Header, Get_Run_Pay_Calculation_RequestType Get_Run_Pay_Calculation_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Run_Pay_Calculation_Request = Get_Run_Pay_Calculation_Request;
		}
	}
}
