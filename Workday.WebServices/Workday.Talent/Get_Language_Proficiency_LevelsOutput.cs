using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Language_Proficiency_LevelsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Language_Proficiency_Levels_ResponseType Get_Language_Proficiency_Levels_Response;

		public Get_Language_Proficiency_LevelsOutput()
		{
		}

		public Get_Language_Proficiency_LevelsOutput(Get_Language_Proficiency_Levels_ResponseType Get_Language_Proficiency_Levels_Response)
		{
			this.Get_Language_Proficiency_Levels_Response = Get_Language_Proficiency_Levels_Response;
		}
	}
}
