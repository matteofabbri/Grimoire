using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Unpost_JobOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Unpost_Job_ResponseType Unpost_Job_Response;

		public Unpost_JobOutput()
		{
		}

		public Unpost_JobOutput(Unpost_Job_ResponseType Unpost_Job_Response)
		{
			this.Unpost_Job_Response = Unpost_Job_Response;
		}
	}
}
