using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Count_InventoryInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Count_Inventory_RequestType Submit_Count_Inventory_Request;

		public Submit_Count_InventoryInput()
		{
		}

		public Submit_Count_InventoryInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Count_Inventory_RequestType Submit_Count_Inventory_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Count_Inventory_Request = Submit_Count_Inventory_Request;
		}
	}
}
