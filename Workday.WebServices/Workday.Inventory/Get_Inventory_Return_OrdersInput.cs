using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Inventory
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Inventory_Return_OrdersInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Inventory_Return_Orders_RequestType Get_Inventory_Return_Orders_Request;

		public Get_Inventory_Return_OrdersInput()
		{
		}

		public Get_Inventory_Return_OrdersInput(Workday_Common_HeaderType Workday_Common_Header, Get_Inventory_Return_Orders_RequestType Get_Inventory_Return_Orders_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Inventory_Return_Orders_Request = Get_Inventory_Return_Orders_Request;
		}
	}
}
