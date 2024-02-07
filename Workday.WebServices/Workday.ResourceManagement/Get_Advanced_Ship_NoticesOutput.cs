using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Advanced_Ship_NoticesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Advanced_Ship_Notices_ResponseType Get_Advanced_Ship_Notices_Response;

		public Get_Advanced_Ship_NoticesOutput()
		{
		}

		public Get_Advanced_Ship_NoticesOutput(Get_Advanced_Ship_Notices_ResponseType Get_Advanced_Ship_Notices_Response)
		{
			this.Get_Advanced_Ship_Notices_Response = Get_Advanced_Ship_Notices_Response;
		}
	}
}
