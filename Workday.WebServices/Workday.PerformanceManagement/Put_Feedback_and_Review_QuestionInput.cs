using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Feedback_and_Review_QuestionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Feedback_and_Review_Question_RequestType Put_Feedback_and_Review_Question_Request;

		public Put_Feedback_and_Review_QuestionInput()
		{
		}

		public Put_Feedback_and_Review_QuestionInput(Workday_Common_HeaderType Workday_Common_Header, Put_Feedback_and_Review_Question_RequestType Put_Feedback_and_Review_Question_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Feedback_and_Review_Question_Request = Put_Feedback_and_Review_Question_Request;
		}
	}
}
