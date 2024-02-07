using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Skill_Profile_CategoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Skill_Profile_Category_ResponseType Put_Skill_Profile_Category_Response;

		public Put_Skill_Profile_CategoryOutput()
		{
		}

		public Put_Skill_Profile_CategoryOutput(Put_Skill_Profile_Category_ResponseType Put_Skill_Profile_Category_Response)
		{
			this.Put_Skill_Profile_Category_Response = Put_Skill_Profile_Category_Response;
		}
	}
}
