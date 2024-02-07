using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_SubscriptionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Subscription_RequestType Put_Subscription_Request;

		public Put_SubscriptionInput()
		{
		}

		public Put_SubscriptionInput(Workday_Common_HeaderType Workday_Common_Header, Put_Subscription_RequestType Put_Subscription_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Subscription_Request = Put_Subscription_Request;
		}
	}
}
