using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Skill_Source_PrecedencesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Skill_Source_Precedences_ResponseType Get_Skill_Source_Precedences_Response;

		public Get_Skill_Source_PrecedencesOutput()
		{
		}

		public Get_Skill_Source_PrecedencesOutput(Get_Skill_Source_Precedences_ResponseType Get_Skill_Source_Precedences_Response)
		{
			this.Get_Skill_Source_Precedences_Response = Get_Skill_Source_Precedences_Response;
		}
	}
}
