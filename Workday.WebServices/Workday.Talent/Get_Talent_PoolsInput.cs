using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Talent_PoolsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Talent_Pools_RequestType Get_Talent_Pools_Request;

		public Get_Talent_PoolsInput()
		{
		}

		public Get_Talent_PoolsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Talent_Pools_RequestType Get_Talent_Pools_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Talent_Pools_Request = Get_Talent_Pools_Request;
		}
	}
}
