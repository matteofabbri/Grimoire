using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_SubawardsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Subawards_RequestType Get_Subawards_Request;

		public Get_SubawardsInput()
		{
		}

		public Get_SubawardsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Subawards_RequestType Get_Subawards_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Subawards_Request = Get_Subawards_Request;
		}
	}
}
