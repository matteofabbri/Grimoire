using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Inventory_Par_LocationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Inventory_Par_Locations_ResponseType Get_Inventory_Par_Locations_Response;

		public Get_Inventory_Par_LocationsOutput()
		{
		}

		public Get_Inventory_Par_LocationsOutput(Get_Inventory_Par_Locations_ResponseType Get_Inventory_Par_Locations_Response)
		{
			this.Get_Inventory_Par_Locations_Response = Get_Inventory_Par_Locations_Response;
		}
	}
}
