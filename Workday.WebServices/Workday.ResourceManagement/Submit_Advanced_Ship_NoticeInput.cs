using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Advanced_Ship_NoticeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Advanced_Ship_Notice_RequestType Submit_Advanced_Ship_Notice_Request;

		public Submit_Advanced_Ship_NoticeInput()
		{
		}

		public Submit_Advanced_Ship_NoticeInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Advanced_Ship_Notice_RequestType Submit_Advanced_Ship_Notice_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Advanced_Ship_Notice_Request = Submit_Advanced_Ship_Notice_Request;
		}
	}
}
