using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CampusEngagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Engagement_Conversation_TagOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Engagement_Conversation_Tag_ResponseType Put_Engagement_Conversation_Tag_Response;

		public Put_Engagement_Conversation_TagOutput()
		{
		}

		public Put_Engagement_Conversation_TagOutput(Put_Engagement_Conversation_Tag_ResponseType Put_Engagement_Conversation_Tag_Response)
		{
			this.Put_Engagement_Conversation_Tag_Response = Put_Engagement_Conversation_Tag_Response;
		}
	}
}
