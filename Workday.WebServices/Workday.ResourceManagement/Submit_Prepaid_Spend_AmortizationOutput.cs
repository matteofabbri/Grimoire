using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Prepaid_Spend_AmortizationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Prepaid_Spend_Amortization_ResponseType Submit_Prepaid_Spend_Amortization_Response;

		public Submit_Prepaid_Spend_AmortizationOutput()
		{
		}

		public Submit_Prepaid_Spend_AmortizationOutput(Submit_Prepaid_Spend_Amortization_ResponseType Submit_Prepaid_Spend_Amortization_Response)
		{
			this.Submit_Prepaid_Spend_Amortization_Response = Submit_Prepaid_Spend_Amortization_Response;
		}
	}
}
