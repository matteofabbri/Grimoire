using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_MentorshipsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Mentorships_RequestType Get_Mentorships_Request;

		public Get_MentorshipsInput()
		{
		}

		public Get_MentorshipsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Mentorships_RequestType Get_Mentorships_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Mentorships_Request = Get_Mentorships_Request;
		}
	}
}
