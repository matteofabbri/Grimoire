using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Item_LotsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Item_Lots_ResponseType Get_Item_Lots_Response;

		public Get_Item_LotsOutput()
		{
		}

		public Get_Item_LotsOutput(Get_Item_Lots_ResponseType Get_Item_Lots_Response)
		{
			this.Get_Item_Lots_Response = Get_Item_Lots_Response;
		}
	}
}
