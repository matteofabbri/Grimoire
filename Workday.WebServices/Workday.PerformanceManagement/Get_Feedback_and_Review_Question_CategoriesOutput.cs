using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Feedback_and_Review_Question_CategoriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Feedback_and_Review_Question_Categories_ResponseType Get_Feedback_and_Review_Question_Categories_Response;

		public Get_Feedback_and_Review_Question_CategoriesOutput()
		{
		}

		public Get_Feedback_and_Review_Question_CategoriesOutput(Get_Feedback_and_Review_Question_Categories_ResponseType Get_Feedback_and_Review_Question_Categories_Response)
		{
			this.Get_Feedback_and_Review_Question_Categories_Response = Get_Feedback_and_Review_Question_Categories_Response;
		}
	}
}
