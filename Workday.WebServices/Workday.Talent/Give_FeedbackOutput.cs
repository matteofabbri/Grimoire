using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Give_FeedbackOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Give_Feedback_ResponseType Give_Feedback_Response;

		public Give_FeedbackOutput()
		{
		}

		public Give_FeedbackOutput(Give_Feedback_ResponseType Give_Feedback_Response)
		{
			this.Give_Feedback_Response = Give_Feedback_Response;
		}
	}
}
