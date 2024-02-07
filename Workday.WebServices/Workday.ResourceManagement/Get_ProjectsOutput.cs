using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ProjectsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Projects_ResponseType Get_Projects_Response;

		public Get_ProjectsOutput()
		{
		}

		public Get_ProjectsOutput(Get_Projects_ResponseType Get_Projects_Response)
		{
			this.Get_Projects_Response = Get_Projects_Response;
		}
	}
}
