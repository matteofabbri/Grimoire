using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Succession_StrategyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Succession_Strategy_ResponseType Put_Succession_Strategy_Response;

		public Put_Succession_StrategyOutput()
		{
		}

		public Put_Succession_StrategyOutput(Put_Succession_Strategy_ResponseType Put_Succession_Strategy_Response)
		{
			this.Put_Succession_Strategy_Response = Put_Succession_Strategy_Response;
		}
	}
}
