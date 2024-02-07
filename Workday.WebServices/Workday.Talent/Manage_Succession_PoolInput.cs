using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Succession_PoolInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Succession_Pool_RequestType Manage_Succession_Pool_Request;

		public Manage_Succession_PoolInput()
		{
		}

		public Manage_Succession_PoolInput(Workday_Common_HeaderType Workday_Common_Header, Manage_Succession_Pool_RequestType Manage_Succession_Pool_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Manage_Succession_Pool_Request = Manage_Succession_Pool_Request;
		}
	}
}
