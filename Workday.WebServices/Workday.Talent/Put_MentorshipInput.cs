using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_MentorshipInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Mentorship_RequestType Put_Mentorship_Request;

		public Put_MentorshipInput()
		{
		}

		public Put_MentorshipInput(Workday_Common_HeaderType Workday_Common_Header, Put_Mentorship_RequestType Put_Mentorship_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Mentorship_Request = Put_Mentorship_Request;
		}
	}
}
