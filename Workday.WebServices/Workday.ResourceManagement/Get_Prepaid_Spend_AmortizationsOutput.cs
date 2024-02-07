using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Prepaid_Spend_AmortizationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Prepaid_Spend_Amortizations_ResponseType Get_Prepaid_Spend_Amortizations_Response;

		public Get_Prepaid_Spend_AmortizationsOutput()
		{
		}

		public Get_Prepaid_Spend_AmortizationsOutput(Get_Prepaid_Spend_Amortizations_ResponseType Get_Prepaid_Spend_Amortizations_Response)
		{
			this.Get_Prepaid_Spend_Amortizations_Response = Get_Prepaid_Spend_Amortizations_Response;
		}
	}
}
