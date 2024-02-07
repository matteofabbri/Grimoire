using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Advanced_Ship_NoticeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Advanced_Ship_Notice_ResponseType Submit_Advanced_Ship_Notice_Response;

		public Submit_Advanced_Ship_NoticeOutput()
		{
		}

		public Submit_Advanced_Ship_NoticeOutput(Submit_Advanced_Ship_Notice_ResponseType Submit_Advanced_Ship_Notice_Response)
		{
			this.Submit_Advanced_Ship_Notice_Response = Submit_Advanced_Ship_Notice_Response;
		}
	}
}
