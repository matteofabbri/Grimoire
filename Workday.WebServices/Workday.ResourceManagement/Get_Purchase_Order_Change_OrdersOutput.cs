using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Purchase_Order_Change_OrdersOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Purchase_Order_Change_Orders_ResponseType Get_Purchase_Order_Change_Orders_Response;

		public Get_Purchase_Order_Change_OrdersOutput()
		{
		}

		public Get_Purchase_Order_Change_OrdersOutput(Get_Purchase_Order_Change_Orders_ResponseType Get_Purchase_Order_Change_Orders_Response)
		{
			this.Get_Purchase_Order_Change_Orders_Response = Get_Purchase_Order_Change_Orders_Response;
		}
	}
}
