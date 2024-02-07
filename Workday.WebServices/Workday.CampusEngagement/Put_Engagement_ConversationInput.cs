using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CampusEngagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Engagement_ConversationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Engagement_Conversation_RequestType Put_Engagement_Conversation_Request;

		public Put_Engagement_ConversationInput()
		{
		}

		public Put_Engagement_ConversationInput(Workday_Common_HeaderType Workday_Common_Header, Put_Engagement_Conversation_RequestType Put_Engagement_Conversation_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Engagement_Conversation_Request = Put_Engagement_Conversation_Request;
		}
	}
}
