using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Advanced_Ship_NoticeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Advanced_Ship_Notice_ResponseType Cancel_Advanced_Ship_Notice_Response;

		public Cancel_Advanced_Ship_NoticeOutput()
		{
		}

		public Cancel_Advanced_Ship_NoticeOutput(Cancel_Advanced_Ship_Notice_ResponseType Cancel_Advanced_Ship_Notice_Response)
		{
			this.Cancel_Advanced_Ship_Notice_Response = Cancel_Advanced_Ship_Notice_Response;
		}
	}
}
