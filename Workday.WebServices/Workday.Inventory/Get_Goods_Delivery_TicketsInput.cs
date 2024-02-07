using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Goods_Delivery_TicketsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Goods_Delivery_Tickets_RequestType Get_Goods_Delivery_Tickets_Request;

		public Get_Goods_Delivery_TicketsInput()
		{
		}

		public Get_Goods_Delivery_TicketsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Goods_Delivery_Tickets_RequestType Get_Goods_Delivery_Tickets_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Goods_Delivery_Tickets_Request = Get_Goods_Delivery_Tickets_Request;
		}
	}
}
