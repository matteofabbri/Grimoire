using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Skill_ProfilesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Skill_Profiles_RequestType Get_Skill_Profiles_Request;

		public Get_Skill_ProfilesInput()
		{
		}

		public Get_Skill_ProfilesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Skill_Profiles_RequestType Get_Skill_Profiles_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Skill_Profiles_Request = Get_Skill_Profiles_Request;
		}
	}
}
