using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Update_Job_PostingOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Update_Job_Posting_ResponseType Update_Job_Posting_Response;

		public Update_Job_PostingOutput()
		{
		}

		public Update_Job_PostingOutput(Update_Job_Posting_ResponseType Update_Job_Posting_Response)
		{
			this.Update_Job_Posting_Response = Update_Job_Posting_Response;
		}
	}
}
