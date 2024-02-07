using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Feedback_and_Review_QuestionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Feedback_and_Review_Questions_RequestType Get_Feedback_and_Review_Questions_Request;

		public Get_Feedback_and_Review_QuestionsInput()
		{
		}

		public Get_Feedback_and_Review_QuestionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Feedback_and_Review_Questions_RequestType Get_Feedback_and_Review_Questions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Feedback_and_Review_Questions_Request = Get_Feedback_and_Review_Questions_Request;
		}
	}
}
