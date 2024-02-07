using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Manage_SkillsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Manage_Skills_ResponseType Get_Manage_Skills_Response;

		public Get_Manage_SkillsOutput()
		{
		}

		public Get_Manage_SkillsOutput(Get_Manage_Skills_ResponseType Get_Manage_Skills_Response)
		{
			this.Get_Manage_Skills_Response = Get_Manage_Skills_Response;
		}
	}
}
