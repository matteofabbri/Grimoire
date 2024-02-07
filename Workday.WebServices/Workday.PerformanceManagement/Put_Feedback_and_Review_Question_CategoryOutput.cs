using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Feedback_and_Review_Question_CategoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Feedback_and_Review_Question_Category_ResponseType Put_Feedback_and_Review_Question_Category_Response;

		public Put_Feedback_and_Review_Question_CategoryOutput()
		{
		}

		public Put_Feedback_and_Review_Question_CategoryOutput(Put_Feedback_and_Review_Question_Category_ResponseType Put_Feedback_and_Review_Question_Category_Response)
		{
			this.Put_Feedback_and_Review_Question_Category_Response = Put_Feedback_and_Review_Question_Category_Response;
		}
	}
}
