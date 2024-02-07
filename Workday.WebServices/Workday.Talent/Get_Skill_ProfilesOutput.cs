using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Skill_ProfilesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Skill_Profiles_ResponseType Get_Skill_Profiles_Response;

		public Get_Skill_ProfilesOutput()
		{
		}

		public Get_Skill_ProfilesOutput(Get_Skill_Profiles_ResponseType Get_Skill_Profiles_Response)
		{
			this.Get_Skill_Profiles_Response = Get_Skill_Profiles_Response;
		}
	}
}
