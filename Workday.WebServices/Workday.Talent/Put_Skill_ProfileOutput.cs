using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Skill_ProfileOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Skill_Profile_ResponseType Put_Skill_Profile_Response;

		public Put_Skill_ProfileOutput()
		{
		}

		public Put_Skill_ProfileOutput(Put_Skill_Profile_ResponseType Put_Skill_Profile_Response)
		{
			this.Put_Skill_Profile_Response = Put_Skill_Profile_Response;
		}
	}
}
