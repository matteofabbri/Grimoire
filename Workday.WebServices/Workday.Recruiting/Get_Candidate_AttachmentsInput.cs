using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Candidate_AttachmentsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Candidate_Attachments_RequestType Get_Candidate_Attachments_Request;

		public Get_Candidate_AttachmentsInput()
		{
		}

		public Get_Candidate_AttachmentsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Candidate_Attachments_RequestType Get_Candidate_Attachments_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Candidate_Attachments_Request = Get_Candidate_Attachments_Request;
		}
	}
}
