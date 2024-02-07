using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Close_Goods_DeliveryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Close_Goods_Delivery_ResponseType Close_Goods_Delivery_Response;

		public Close_Goods_DeliveryOutput()
		{
		}

		public Close_Goods_DeliveryOutput(Close_Goods_Delivery_ResponseType Close_Goods_Delivery_Response)
		{
			this.Close_Goods_Delivery_Response = Close_Goods_Delivery_Response;
		}
	}
}
