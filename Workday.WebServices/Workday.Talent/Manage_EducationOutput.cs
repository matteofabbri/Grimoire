using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_EducationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Education_ResponseType Manage_Education_Response;

		public Manage_EducationOutput()
		{
		}

		public Manage_EducationOutput(Manage_Education_ResponseType Manage_Education_Response)
		{
			this.Manage_Education_Response = Manage_Education_Response;
		}
	}
}
