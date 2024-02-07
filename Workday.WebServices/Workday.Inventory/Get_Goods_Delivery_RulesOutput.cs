using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Goods_Delivery_RulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Goods_Delivery_Rules_ResponseType Get_Goods_Delivery_Rules_Response;

		public Get_Goods_Delivery_RulesOutput()
		{
		}

		public Get_Goods_Delivery_RulesOutput(Get_Goods_Delivery_Rules_ResponseType Get_Goods_Delivery_Rules_Response)
		{
			this.Get_Goods_Delivery_Rules_Response = Get_Goods_Delivery_Rules_Response;
		}
	}
}
