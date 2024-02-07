using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_SkillOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Skill_ResponseType Put_Skill_Response;

		public Put_SkillOutput()
		{
		}

		public Put_SkillOutput(Put_Skill_ResponseType Put_Skill_Response)
		{
			this.Put_Skill_Response = Put_Skill_Response;
		}
	}
}
