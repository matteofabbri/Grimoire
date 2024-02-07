using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Candidate_AttachmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Candidate_Attachments_ResponseType Get_Candidate_Attachments_Response;

		public Get_Candidate_AttachmentsOutput()
		{
		}

		public Get_Candidate_AttachmentsOutput(Get_Candidate_Attachments_ResponseType Get_Candidate_Attachments_Response)
		{
			this.Get_Candidate_Attachments_Response = Get_Candidate_Attachments_Response;
		}
	}
}
