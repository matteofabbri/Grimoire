using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Cash_SaleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Cash_Sale_ResponseType Submit_Cash_Sale_Response;

		public Submit_Cash_SaleOutput()
		{
		}

		public Submit_Cash_SaleOutput(Submit_Cash_Sale_ResponseType Submit_Cash_Sale_Response)
		{
			this.Submit_Cash_Sale_Response = Submit_Cash_Sale_Response;
		}
	}
}
