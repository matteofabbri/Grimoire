using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Payroll
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Withholding_Order_Local_Minimum_Wage_RateInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Withholding_Order_Local_Minimum_Wage_Rate_RequestType Get_Withholding_Order_Local_Minimum_Wage_Rate_Request;

		public Get_Withholding_Order_Local_Minimum_Wage_RateInput()
		{
		}

		public Get_Withholding_Order_Local_Minimum_Wage_RateInput(Workday_Common_HeaderType Workday_Common_Header, Get_Withholding_Order_Local_Minimum_Wage_Rate_RequestType Get_Withholding_Order_Local_Minimum_Wage_Rate_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Withholding_Order_Local_Minimum_Wage_Rate_Request = Get_Withholding_Order_Local_Minimum_Wage_Rate_Request;
		}
	}
}
