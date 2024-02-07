using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Item_LotsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Item_Lots_RequestType Get_Item_Lots_Request;

		public Get_Item_LotsInput()
		{
		}

		public Get_Item_LotsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Item_Lots_RequestType Get_Item_Lots_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Item_Lots_Request = Get_Item_Lots_Request;
		}
	}
}
