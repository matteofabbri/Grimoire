using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Customer_RefundInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Customer_Refund_RequestType Submit_Customer_Refund_Request;

		public Submit_Customer_RefundInput()
		{
		}

		public Submit_Customer_RefundInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Customer_Refund_RequestType Submit_Customer_Refund_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Customer_Refund_Request = Submit_Customer_Refund_Request;
		}
	}
}
