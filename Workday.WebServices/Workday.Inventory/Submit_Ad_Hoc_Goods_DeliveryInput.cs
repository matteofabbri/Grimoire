using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Ad_Hoc_Goods_DeliveryInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Ad_Hoc_Goods_Delivery_RequestType Submit_Ad_Hoc_Goods_Delivery_Request;

		public Submit_Ad_Hoc_Goods_DeliveryInput()
		{
		}

		public Submit_Ad_Hoc_Goods_DeliveryInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Ad_Hoc_Goods_Delivery_RequestType Submit_Ad_Hoc_Goods_Delivery_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Ad_Hoc_Goods_Delivery_Request = Submit_Ad_Hoc_Goods_Delivery_Request;
		}
	}
}
