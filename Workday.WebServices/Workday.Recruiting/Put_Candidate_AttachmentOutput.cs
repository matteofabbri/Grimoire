using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Candidate_AttachmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Candidate_Attachment_ResponseType Put_Candidate_Attachment_Response;

		public Put_Candidate_AttachmentOutput()
		{
		}

		public Put_Candidate_AttachmentOutput(Put_Candidate_Attachment_ResponseType Put_Candidate_Attachment_Response)
		{
			this.Put_Candidate_Attachment_Response = Put_Candidate_Attachment_Response;
		}
	}
}
