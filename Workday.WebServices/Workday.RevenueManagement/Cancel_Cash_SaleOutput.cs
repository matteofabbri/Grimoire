using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Cash_SaleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Cash_Sale_ResponseType Cancel_Cash_Sale_Response;

		public Cancel_Cash_SaleOutput()
		{
		}

		public Cancel_Cash_SaleOutput(Cancel_Cash_Sale_ResponseType Cancel_Cash_Sale_Response)
		{
			this.Cancel_Cash_Sale_Response = Cancel_Cash_Sale_Response;
		}
	}
}
