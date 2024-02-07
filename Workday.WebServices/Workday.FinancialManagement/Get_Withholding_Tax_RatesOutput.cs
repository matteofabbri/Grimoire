using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Withholding_Tax_RatesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Withholding_Tax_Rates_ResponseType Get_Withholding_Tax_Rates_Response;

		public Get_Withholding_Tax_RatesOutput()
		{
		}

		public Get_Withholding_Tax_RatesOutput(Get_Withholding_Tax_Rates_ResponseType Get_Withholding_Tax_Rates_Response)
		{
			this.Get_Withholding_Tax_Rates_Response = Get_Withholding_Tax_Rates_Response;
		}
	}
}
