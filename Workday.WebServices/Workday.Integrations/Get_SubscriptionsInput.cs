using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_SubscriptionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Subscriptions_RequestType Get_Subscriptions_Request;

		public Get_SubscriptionsInput()
		{
		}

		public Get_SubscriptionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Subscriptions_RequestType Get_Subscriptions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Subscriptions_Request = Get_Subscriptions_Request;
		}
	}
}
