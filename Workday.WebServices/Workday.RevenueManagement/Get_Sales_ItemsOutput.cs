using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Sales_ItemsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Sales_Items_ResponseType Get_Sales_Items_Response;

		public Get_Sales_ItemsOutput()
		{
		}

		public Get_Sales_ItemsOutput(Get_Sales_Items_ResponseType Get_Sales_Items_Response)
		{
			this.Get_Sales_Items_Response = Get_Sales_Items_Response;
		}
	}
}
