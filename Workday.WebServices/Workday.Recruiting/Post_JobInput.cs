using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Post_JobInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Post_Job_RequestType Post_Job_Request;

		public Post_JobInput()
		{
		}

		public Post_JobInput(Workday_Common_HeaderType Workday_Common_Header, Post_Job_RequestType Post_Job_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Post_Job_Request = Post_Job_Request;
		}
	}
}
