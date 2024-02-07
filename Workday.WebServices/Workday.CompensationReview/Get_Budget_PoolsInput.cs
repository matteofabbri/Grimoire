using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Budget_PoolsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Budget_Pools_RequestType Get_Budget_Pools_Request;

		public Get_Budget_PoolsInput()
		{
		}

		public Get_Budget_PoolsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Budget_Pools_RequestType Get_Budget_Pools_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Budget_Pools_Request = Get_Budget_Pools_Request;
		}
	}
}
