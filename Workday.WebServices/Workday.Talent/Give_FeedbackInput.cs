using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Give_FeedbackInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Give_Feedback_RequestType Give_Feedback_Request;

		public Give_FeedbackInput()
		{
		}

		public Give_FeedbackInput(Workday_Common_HeaderType Workday_Common_Header, Give_Feedback_RequestType Give_Feedback_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Give_Feedback_Request = Give_Feedback_Request;
		}
	}
}
