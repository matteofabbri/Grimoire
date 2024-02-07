using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Transaction_Tax_RatesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Tax_Rates_ResponseType Get_Tax_Rates_Response;

		public Get_Transaction_Tax_RatesOutput()
		{
		}

		public Get_Transaction_Tax_RatesOutput(Get_Tax_Rates_ResponseType Get_Tax_Rates_Response)
		{
			this.Get_Tax_Rates_Response = Get_Tax_Rates_Response;
		}
	}
}
