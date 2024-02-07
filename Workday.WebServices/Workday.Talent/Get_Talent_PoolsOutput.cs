using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Talent_PoolsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Talent_Pools_ResponseType Get_Talent_Pools_Response;

		public Get_Talent_PoolsOutput()
		{
		}

		public Get_Talent_PoolsOutput(Get_Talent_Pools_ResponseType Get_Talent_Pools_Response)
		{
			this.Get_Talent_Pools_Response = Get_Talent_Pools_Response;
		}
	}
}
