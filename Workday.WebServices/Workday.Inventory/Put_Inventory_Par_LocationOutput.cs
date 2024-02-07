using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Inventory_Par_LocationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Inventory_Par_Location_ResponseType Put_Inventory_Par_Location_Response;

		public Put_Inventory_Par_LocationOutput()
		{
		}

		public Put_Inventory_Par_LocationOutput(Put_Inventory_Par_Location_ResponseType Put_Inventory_Par_Location_Response)
		{
			this.Put_Inventory_Par_Location_Response = Put_Inventory_Par_Location_Response;
		}
	}
}
