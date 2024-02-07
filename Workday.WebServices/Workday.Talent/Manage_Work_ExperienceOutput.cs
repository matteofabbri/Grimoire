using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Work_ExperienceOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Work_Experiences_ResponseType Manage_Work_Experiences_Response;

		public Manage_Work_ExperienceOutput()
		{
		}

		public Manage_Work_ExperienceOutput(Manage_Work_Experiences_ResponseType Manage_Work_Experiences_Response)
		{
			this.Manage_Work_Experiences_Response = Manage_Work_Experiences_Response;
		}
	}
}
