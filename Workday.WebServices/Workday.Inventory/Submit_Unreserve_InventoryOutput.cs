using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Unreserve_InventoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Unreserve_Inventory_ResponseType Submit_Unreserve_Inventory_Response;

		public Submit_Unreserve_InventoryOutput()
		{
		}

		public Submit_Unreserve_InventoryOutput(Submit_Unreserve_Inventory_ResponseType Submit_Unreserve_Inventory_Response)
		{
			this.Submit_Unreserve_Inventory_Response = Submit_Unreserve_Inventory_Response;
		}
	}
}
