using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_JobOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Job_ResponseType Change_Job_Response;

		public Change_JobOutput()
		{
		}

		public Change_JobOutput(Change_Job_ResponseType Change_Job_Response)
		{
			this.Change_Job_Response = Change_Job_Response;
		}
	}
}
