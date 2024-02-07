using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Inventory_Par_LocationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Inventory_Par_Location_RequestType Put_Inventory_Par_Location_Request;

		public Put_Inventory_Par_LocationInput()
		{
		}

		public Put_Inventory_Par_LocationInput(Workday_Common_HeaderType Workday_Common_Header, Put_Inventory_Par_Location_RequestType Put_Inventory_Par_Location_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Inventory_Par_Location_Request = Put_Inventory_Par_Location_Request;
		}
	}
}
