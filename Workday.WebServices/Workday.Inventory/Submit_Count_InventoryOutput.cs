using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Count_InventoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Count_Inventory_ResponseType Submit_Count_Inventory_Response;

		public Submit_Count_InventoryOutput()
		{
		}

		public Submit_Count_InventoryOutput(Submit_Count_Inventory_ResponseType Submit_Count_Inventory_Response)
		{
			this.Submit_Count_Inventory_Response = Submit_Count_Inventory_Response;
		}
	}
}
