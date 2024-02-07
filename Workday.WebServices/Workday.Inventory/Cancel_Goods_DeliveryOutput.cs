using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Goods_DeliveryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Goods_Delivery_ResponseType Cancel_Goods_Delivery_Response;

		public Cancel_Goods_DeliveryOutput()
		{
		}

		public Cancel_Goods_DeliveryOutput(Cancel_Goods_Delivery_ResponseType Cancel_Goods_Delivery_Response)
		{
			this.Cancel_Goods_Delivery_Response = Cancel_Goods_Delivery_Response;
		}
	}
}
