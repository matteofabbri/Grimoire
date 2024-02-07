using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Gift_Secured_AttachmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Gift_Secured_Attachment_ResponseType Put_Gift_Secured_Attachment_Response;

		public Put_Gift_Secured_AttachmentOutput()
		{
		}

		public Put_Gift_Secured_AttachmentOutput(Put_Gift_Secured_Attachment_ResponseType Put_Gift_Secured_Attachment_Response)
		{
			this.Put_Gift_Secured_Attachment_Response = Put_Gift_Secured_Attachment_Response;
		}
	}
}
