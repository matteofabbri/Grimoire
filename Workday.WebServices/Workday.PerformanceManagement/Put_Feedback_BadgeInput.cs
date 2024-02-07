using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Feedback_BadgeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Feedback_Badge_RequestType Put_Feedback_Badge_Request;

		public Put_Feedback_BadgeInput()
		{
		}

		public Put_Feedback_BadgeInput(Workday_Common_HeaderType Workday_Common_Header, Put_Feedback_Badge_RequestType Put_Feedback_Badge_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Feedback_Badge_Request = Put_Feedback_Badge_Request;
		}
	}
}
