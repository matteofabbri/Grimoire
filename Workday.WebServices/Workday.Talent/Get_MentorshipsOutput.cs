using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_MentorshipsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Mentorships_ResponseType Get_Mentorships_Response;

		public Get_MentorshipsOutput()
		{
		}

		public Get_MentorshipsOutput(Get_Mentorships_ResponseType Get_Mentorships_Response)
		{
			this.Get_Mentorships_Response = Get_Mentorships_Response;
		}
	}
}
