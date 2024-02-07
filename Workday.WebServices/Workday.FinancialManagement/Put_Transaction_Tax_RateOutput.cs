using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Transaction_Tax_RateOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Tax_Rate_ResponseType Put_Tax_Rate_Response;

		public Put_Transaction_Tax_RateOutput()
		{
		}

		public Put_Transaction_Tax_RateOutput(Put_Tax_Rate_ResponseType Put_Tax_Rate_Response)
		{
			this.Put_Tax_Rate_Response = Put_Tax_Rate_Response;
		}
	}
}
