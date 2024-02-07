using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_SubscriptionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Subscriptions_ResponseType Get_Subscriptions_Response;

		public Get_SubscriptionsOutput()
		{
		}

		public Get_SubscriptionsOutput(Get_Subscriptions_ResponseType Get_Subscriptions_Response)
		{
			this.Get_Subscriptions_Response = Get_Subscriptions_Response;
		}
	}
}
