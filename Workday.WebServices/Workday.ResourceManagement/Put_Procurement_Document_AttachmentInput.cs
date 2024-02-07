using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Procurement_Document_AttachmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Procurement_Document_Attachment_RequestType Put_Procurement_Document_Attachment_Request;

		public Put_Procurement_Document_AttachmentInput()
		{
		}

		public Put_Procurement_Document_AttachmentInput(Workday_Common_HeaderType Workday_Common_Header, Put_Procurement_Document_Attachment_RequestType Put_Procurement_Document_Attachment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Procurement_Document_Attachment_Request = Put_Procurement_Document_Attachment_Request;
		}
	}
}
