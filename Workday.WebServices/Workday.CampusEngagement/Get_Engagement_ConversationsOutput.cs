using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CampusEngagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Engagement_ConversationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Engagement_Conversations_ResponseType Get_Engagement_Conversations_Response;

		public Get_Engagement_ConversationsOutput()
		{
		}

		public Get_Engagement_ConversationsOutput(Get_Engagement_Conversations_ResponseType Get_Engagement_Conversations_Response)
		{
			this.Get_Engagement_Conversations_Response = Get_Engagement_Conversations_Response;
		}
	}
}
