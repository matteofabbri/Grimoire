using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Item_LotOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Item_Lot_ResponseType Put_Item_Lot_Response;

		public Put_Item_LotOutput()
		{
		}

		public Put_Item_LotOutput(Put_Item_Lot_ResponseType Put_Item_Lot_Response)
		{
			this.Put_Item_Lot_Response = Put_Item_Lot_Response;
		}
	}
}
