using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Internal_ProjectsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Internal_Projects_ResponseType Manage_Internal_Projects_Response;

		public Manage_Internal_ProjectsOutput()
		{
		}

		public Manage_Internal_ProjectsOutput(Manage_Internal_Projects_ResponseType Manage_Internal_Projects_Response)
		{
			this.Manage_Internal_Projects_Response = Manage_Internal_Projects_Response;
		}
	}
}
