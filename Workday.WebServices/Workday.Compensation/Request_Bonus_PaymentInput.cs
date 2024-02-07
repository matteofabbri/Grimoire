using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Request_Bonus_PaymentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Request_Bonus_Payment_RequestType Request_Bonus_Payment_Request;

		public Request_Bonus_PaymentInput()
		{
		}

		public Request_Bonus_PaymentInput(Workday_Common_HeaderType Workday_Common_Header, Request_Bonus_Payment_RequestType Request_Bonus_Payment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Request_Bonus_Payment_Request = Request_Bonus_Payment_Request;
		}
	}
}
