using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Goods_Delivery_TicketsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Goods_Delivery_Tickets_ResponseType Get_Goods_Delivery_Tickets_Response;

		public Get_Goods_Delivery_TicketsOutput()
		{
		}

		public Get_Goods_Delivery_TicketsOutput(Get_Goods_Delivery_Tickets_ResponseType Get_Goods_Delivery_Tickets_Response)
		{
			this.Get_Goods_Delivery_Tickets_Response = Get_Goods_Delivery_Tickets_Response;
		}
	}
}
