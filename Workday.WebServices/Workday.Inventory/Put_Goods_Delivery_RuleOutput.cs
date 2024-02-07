using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Goods_Delivery_RuleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Goods_Delivery_Rule_ResponseType Put_Goods_Delivery_Rule_Response;

		public Put_Goods_Delivery_RuleOutput()
		{
		}

		public Put_Goods_Delivery_RuleOutput(Put_Goods_Delivery_Rule_ResponseType Put_Goods_Delivery_Rule_Response)
		{
			this.Put_Goods_Delivery_Rule_Response = Put_Goods_Delivery_Rule_Response;
		}
	}
}
