using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_ReceiptInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Receipt_RequestType Submit_Receipt_Request;

		public Submit_ReceiptInput()
		{
		}

		public Submit_ReceiptInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Receipt_RequestType Submit_Receipt_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Receipt_Request = Submit_Receipt_Request;
		}
	}
}
