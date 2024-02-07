using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_PositionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Positions_ResponseType Get_Positions_Response;

		public Get_PositionsOutput()
		{
		}

		public Get_PositionsOutput(Get_Positions_ResponseType Get_Positions_Response)
		{
			this.Get_Positions_Response = Get_Positions_Response;
		}
	}
}
