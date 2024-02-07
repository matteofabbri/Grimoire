using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_ReceiptInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Receipt_RequestType Cancel_Receipt_Request;

		public Cancel_ReceiptInput()
		{
		}

		public Cancel_ReceiptInput(Workday_Common_HeaderType Workday_Common_Header, Cancel_Receipt_RequestType Cancel_Receipt_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Cancel_Receipt_Request = Cancel_Receipt_Request;
		}
	}
}
