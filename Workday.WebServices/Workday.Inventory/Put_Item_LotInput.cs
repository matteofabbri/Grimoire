using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Item_LotInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Item_Lot_RequestType Put_Item_Lot_Request;

		public Put_Item_LotInput()
		{
		}

		public Put_Item_LotInput(Workday_Common_HeaderType Workday_Common_Header, Put_Item_Lot_RequestType Put_Item_Lot_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Item_Lot_Request = Put_Item_Lot_Request;
		}
	}
}
