using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Cash_SalesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Cash_Sales_ResponseType Get_Cash_Sales_Response;

		public Get_Cash_SalesOutput()
		{
		}

		public Get_Cash_SalesOutput(Get_Cash_Sales_ResponseType Get_Cash_Sales_Response)
		{
			this.Get_Cash_Sales_Response = Get_Cash_Sales_Response;
		}
	}
}
