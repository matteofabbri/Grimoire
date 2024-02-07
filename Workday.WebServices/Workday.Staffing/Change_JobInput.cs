using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_JobInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Job_RequestType Change_Job_Request;

		public Change_JobInput()
		{
		}

		public Change_JobInput(Workday_Common_HeaderType Workday_Common_Header, Change_Job_RequestType Change_Job_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Change_Job_Request = Change_Job_Request;
		}
	}
}
