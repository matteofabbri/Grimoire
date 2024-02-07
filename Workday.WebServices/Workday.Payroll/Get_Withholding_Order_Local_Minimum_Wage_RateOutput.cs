using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Withholding_Order_Local_Minimum_Wage_RateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Withholding_Order_Local_Minimum_Wage_Rate_ResponseType Get_Withholding_Order_Local_Minimum_Wage_Rate_Response;

		public Get_Withholding_Order_Local_Minimum_Wage_RateOutput()
		{
		}

		public Get_Withholding_Order_Local_Minimum_Wage_RateOutput(Get_Withholding_Order_Local_Minimum_Wage_Rate_ResponseType Get_Withholding_Order_Local_Minimum_Wage_Rate_Response)
		{
			this.Get_Withholding_Order_Local_Minimum_Wage_Rate_Response = Get_Withholding_Order_Local_Minimum_Wage_Rate_Response;
		}
	}
}
