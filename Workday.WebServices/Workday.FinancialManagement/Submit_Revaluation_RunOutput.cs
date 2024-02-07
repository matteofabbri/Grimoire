using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Revaluation_RunOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Revaluation_Run_ResponseType Submit_Revaluation_Run_Response;

		public Submit_Revaluation_RunOutput()
		{
		}

		public Submit_Revaluation_RunOutput(Submit_Revaluation_Run_ResponseType Submit_Revaluation_Run_Response)
		{
			this.Submit_Revaluation_Run_Response = Submit_Revaluation_Run_Response;
		}
	}
}
