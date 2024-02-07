using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_SubscriptionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Subscription_ResponseType Put_Subscription_Response;

		public Put_SubscriptionOutput()
		{
		}

		public Put_SubscriptionOutput(Put_Subscription_ResponseType Put_Subscription_Response)
		{
			this.Put_Subscription_Response = Put_Subscription_Response;
		}
	}
}
