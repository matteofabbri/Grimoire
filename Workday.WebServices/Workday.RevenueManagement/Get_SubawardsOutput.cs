using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_SubawardsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Subawards_ResponseType Get_Subawards_Response;

		public Get_SubawardsOutput()
		{
		}

		public Get_SubawardsOutput(Get_Subawards_ResponseType Get_Subawards_Response)
		{
			this.Get_Subawards_Response = Get_Subawards_Response;
		}
	}
}
