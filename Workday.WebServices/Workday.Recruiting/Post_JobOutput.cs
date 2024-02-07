using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Post_JobOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Post_Job_ResponseType Post_Job_Response;

		public Post_JobOutput()
		{
		}

		public Post_JobOutput(Post_Job_ResponseType Post_Job_Response)
		{
			this.Post_Job_Response = Post_Job_Response;
		}
	}
}
