using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Update_Job_PostingInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Update_Job_Posting_RequestType Update_Job_Posting_Request;

		public Update_Job_PostingInput()
		{
		}

		public Update_Job_PostingInput(Workday_Common_HeaderType Workday_Common_Header, Update_Job_Posting_RequestType Update_Job_Posting_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Update_Job_Posting_Request = Update_Job_Posting_Request;
		}
	}
}
