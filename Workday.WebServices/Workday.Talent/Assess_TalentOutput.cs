using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assess_TalentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assess_Talent_ResponseType Assess_Talent_Response;

		public Assess_TalentOutput()
		{
		}

		public Assess_TalentOutput(Assess_Talent_ResponseType Assess_Talent_Response)
		{
			this.Assess_Talent_Response = Assess_Talent_Response;
		}
	}
}
