using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Advanced_Ship_NoticesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Advanced_Ship_Notices_RequestType Get_Advanced_Ship_Notices_Request;

		public Get_Advanced_Ship_NoticesInput()
		{
		}

		public Get_Advanced_Ship_NoticesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Advanced_Ship_Notices_RequestType Get_Advanced_Ship_Notices_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Advanced_Ship_Notices_Request = Get_Advanced_Ship_Notices_Request;
		}
	}
}
