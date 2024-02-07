using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Inventory_Location_AttributesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Inventory_Location_Attributes_ResponseType Put_Inventory_Location_Attributes_Response;

		public Put_Inventory_Location_AttributesOutput()
		{
		}

		public Put_Inventory_Location_AttributesOutput(Put_Inventory_Location_Attributes_ResponseType Put_Inventory_Location_Attributes_Response)
		{
			this.Put_Inventory_Location_Attributes_Response = Put_Inventory_Location_Attributes_Response;
		}
	}
}
