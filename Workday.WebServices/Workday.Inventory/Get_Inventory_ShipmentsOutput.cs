using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Inventory_ShipmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Inventory_Shipments_ResponseType Get_Inventory_Shipments_Response;

		public Get_Inventory_ShipmentsOutput()
		{
		}

		public Get_Inventory_ShipmentsOutput(Get_Inventory_Shipments_ResponseType Get_Inventory_Shipments_Response)
		{
			this.Get_Inventory_Shipments_Response = Get_Inventory_Shipments_Response;
		}
	}
}
