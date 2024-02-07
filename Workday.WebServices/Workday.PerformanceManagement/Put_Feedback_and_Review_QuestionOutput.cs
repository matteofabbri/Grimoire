using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Feedback_and_Review_QuestionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Feedback_and_Review_Question_ResponseType Put_Feedback_and_Review_Question_Response;

		public Put_Feedback_and_Review_QuestionOutput()
		{
		}

		public Put_Feedback_and_Review_QuestionOutput(Put_Feedback_and_Review_Question_ResponseType Put_Feedback_and_Review_Question_Response)
		{
			this.Put_Feedback_and_Review_Question_Response = Put_Feedback_and_Review_Question_Response;
		}
	}
}
