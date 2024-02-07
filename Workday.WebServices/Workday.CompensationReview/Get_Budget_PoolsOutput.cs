using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Budget_PoolsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Budget_Pools_ResponseType Get_Budget_Pools_Response;

		public Get_Budget_PoolsOutput()
		{
		}

		public Get_Budget_PoolsOutput(Get_Budget_Pools_ResponseType Get_Budget_Pools_Response)
		{
			this.Get_Budget_Pools_Response = Get_Budget_Pools_Response;
		}
	}
}
