using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Inventory_Location_AttributesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Inventory_Location_Attributes_ResponseType Get_Inventory_Location_Attributes_Response;

		public Get_Inventory_Location_AttributesOutput()
		{
		}

		public Get_Inventory_Location_AttributesOutput(Get_Inventory_Location_Attributes_ResponseType Get_Inventory_Location_Attributes_Response)
		{
			this.Get_Inventory_Location_Attributes_Response = Get_Inventory_Location_Attributes_Response;
		}
	}
}
