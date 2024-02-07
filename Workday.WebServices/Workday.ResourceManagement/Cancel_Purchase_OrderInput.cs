using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Purchase_OrderInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Purchase_Order_RequestType Cancel_Purchase_Order_Request;

		public Cancel_Purchase_OrderInput()
		{
		}

		public Cancel_Purchase_OrderInput(Workday_Common_HeaderType Workday_Common_Header, Cancel_Purchase_Order_RequestType Cancel_Purchase_Order_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Cancel_Purchase_Order_Request = Cancel_Purchase_Order_Request;
		}
	}
}
