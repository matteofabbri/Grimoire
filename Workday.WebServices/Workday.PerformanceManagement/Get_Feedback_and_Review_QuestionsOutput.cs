using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Feedback_and_Review_QuestionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Feedback_and_Review_Questions_ResponseType Get_Feedback_and_Review_Questions_Response;

		public Get_Feedback_and_Review_QuestionsOutput()
		{
		}

		public Get_Feedback_and_Review_QuestionsOutput(Get_Feedback_and_Review_Questions_ResponseType Get_Feedback_and_Review_Questions_Response)
		{
			this.Get_Feedback_and_Review_Questions_Response = Get_Feedback_and_Review_Questions_Response;
		}
	}
}
