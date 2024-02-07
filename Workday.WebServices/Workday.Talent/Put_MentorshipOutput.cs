using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_MentorshipOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Mentorship_Event_ResponseType Put_Mentorship_Event_Response;

		public Put_MentorshipOutput()
		{
		}

		public Put_MentorshipOutput(Put_Mentorship_Event_ResponseType Put_Mentorship_Event_Response)
		{
			this.Put_Mentorship_Event_Response = Put_Mentorship_Event_Response;
		}
	}
}
