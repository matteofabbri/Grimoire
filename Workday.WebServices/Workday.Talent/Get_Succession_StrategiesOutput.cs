using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Succession_StrategiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Succession_Strategies_ResponseType Get_Succession_Strategies_Response;

		public Get_Succession_StrategiesOutput()
		{
		}

		public Get_Succession_StrategiesOutput(Get_Succession_Strategies_ResponseType Get_Succession_Strategies_Response)
		{
			this.Get_Succession_Strategies_Response = Get_Succession_Strategies_Response;
		}
	}
}
