using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_SkillsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Skills_ResponseType Manage_Skills_Response;

		public Manage_SkillsOutput()
		{
		}

		public Manage_SkillsOutput(Manage_Skills_ResponseType Manage_Skills_Response)
		{
			this.Manage_Skills_Response = Manage_Skills_Response;
		}
	}
}
