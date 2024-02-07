using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Unpost_JobInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Unpost_Job_RequestType Unpost_Job_Request;

		public Unpost_JobInput()
		{
		}

		public Unpost_JobInput(Workday_Common_HeaderType Workday_Common_Header, Unpost_Job_RequestType Unpost_Job_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Unpost_Job_Request = Unpost_Job_Request;
		}
	}
}
