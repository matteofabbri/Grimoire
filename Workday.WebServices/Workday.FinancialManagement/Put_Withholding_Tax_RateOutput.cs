using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Withholding_Tax_RateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Withholding_Tax_Rate_ResponseType Put_Withholding_Tax_Rate_Response;

		public Put_Withholding_Tax_RateOutput()
		{
		}

		public Put_Withholding_Tax_RateOutput(Put_Withholding_Tax_Rate_ResponseType Put_Withholding_Tax_Rate_Response)
		{
			this.Put_Withholding_Tax_Rate_Response = Put_Withholding_Tax_Rate_Response;
		}
	}
}
