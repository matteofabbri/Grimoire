using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Purchase_OrdersInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Purchase_Orders_RequestType Get_Purchase_Orders_Request;

		public Get_Purchase_OrdersInput()
		{
		}

		public Get_Purchase_OrdersInput(Workday_Common_HeaderType Workday_Common_Header, Get_Purchase_Orders_RequestType Get_Purchase_Orders_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Purchase_Orders_Request = Get_Purchase_Orders_Request;
		}
	}
}
