using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Procurement_Document_AttachmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Procurement_Document_Attachment_ResponseType Put_Procurement_Document_Attachment_Response;

		public Put_Procurement_Document_AttachmentOutput()
		{
		}

		public Put_Procurement_Document_AttachmentOutput(Put_Procurement_Document_Attachment_ResponseType Put_Procurement_Document_Attachment_Response)
		{
			this.Put_Procurement_Document_Attachment_Response = Put_Procurement_Document_Attachment_Response;
		}
	}
}
