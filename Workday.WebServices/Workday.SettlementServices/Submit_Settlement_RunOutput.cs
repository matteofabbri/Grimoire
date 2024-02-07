using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Settlement_RunOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Settlement_Run_ResponseType Submit_Settlement_Run_Response;

		public Submit_Settlement_RunOutput()
		{
		}

		public Submit_Settlement_RunOutput(Submit_Settlement_Run_ResponseType Submit_Settlement_Run_Response)
		{
			this.Submit_Settlement_Run_Response = Submit_Settlement_Run_Response;
		}
	}
}
