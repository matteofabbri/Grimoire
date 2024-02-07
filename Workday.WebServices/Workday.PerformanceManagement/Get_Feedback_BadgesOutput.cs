using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Feedback_BadgesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Feedback_Badges_ResponseType Get_Feedback_Badges_Response;

		public Get_Feedback_BadgesOutput()
		{
		}

		public Get_Feedback_BadgesOutput(Get_Feedback_Badges_ResponseType Get_Feedback_Badges_Response)
		{
			this.Get_Feedback_Badges_Response = Get_Feedback_Badges_Response;
		}
	}
}
