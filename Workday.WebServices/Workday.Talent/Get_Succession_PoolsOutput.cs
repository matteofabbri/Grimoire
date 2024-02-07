using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Succession_PoolsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Succession_Pools_ResponseType Get_Succession_Pools_Response;

		public Get_Succession_PoolsOutput()
		{
		}

		public Get_Succession_PoolsOutput(Get_Succession_Pools_ResponseType Get_Succession_Pools_Response)
		{
			this.Get_Succession_Pools_Response = Get_Succession_Pools_Response;
		}
	}
}
