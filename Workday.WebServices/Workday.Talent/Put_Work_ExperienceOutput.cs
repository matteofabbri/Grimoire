using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Work_ExperienceOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Work_Experience_ResponseType Put_Work_Experience_Response;

		public Put_Work_ExperienceOutput()
		{
		}

		public Put_Work_ExperienceOutput(Put_Work_Experience_ResponseType Put_Work_Experience_Response)
		{
			this.Put_Work_Experience_Response = Put_Work_Experience_Response;
		}
	}
}
