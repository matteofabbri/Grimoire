using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_SkillInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Skill_RequestType Put_Skill_Request;

		public Put_SkillInput()
		{
		}

		public Put_SkillInput(Workday_Common_HeaderType Workday_Common_Header, Put_Skill_RequestType Put_Skill_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Skill_Request = Put_Skill_Request;
		}
	}
}
