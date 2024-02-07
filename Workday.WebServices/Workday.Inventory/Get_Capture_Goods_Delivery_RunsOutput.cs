using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Capture_Goods_Delivery_RunsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Capture_Goods_Delivery_Runs_ResponseType Get_Capture_Goods_Delivery_Runs_Response;

		public Get_Capture_Goods_Delivery_RunsOutput()
		{
		}

		public Get_Capture_Goods_Delivery_RunsOutput(Get_Capture_Goods_Delivery_Runs_ResponseType Get_Capture_Goods_Delivery_Runs_Response)
		{
			this.Get_Capture_Goods_Delivery_Runs_Response = Get_Capture_Goods_Delivery_Runs_Response;
		}
	}
}
