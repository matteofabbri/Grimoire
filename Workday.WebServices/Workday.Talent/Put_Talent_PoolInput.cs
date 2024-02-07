using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Talent_PoolInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Talent_Pool_RequestType Put_Talent_Pool_Request;

		public Put_Talent_PoolInput()
		{
		}

		public Put_Talent_PoolInput(Workday_Common_HeaderType Workday_Common_Header, Put_Talent_Pool_RequestType Put_Talent_Pool_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Talent_Pool_Request = Put_Talent_Pool_Request;
		}
	}
}
