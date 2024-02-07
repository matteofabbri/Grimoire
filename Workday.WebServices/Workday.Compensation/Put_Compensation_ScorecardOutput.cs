using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Compensation_ScorecardOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Compensation_Scorecard_ResponseType Put_Compensation_Scorecard_Response;

		public Put_Compensation_ScorecardOutput()
		{
		}

		public Put_Compensation_ScorecardOutput(Put_Compensation_Scorecard_ResponseType Put_Compensation_Scorecard_Response)
		{
			this.Put_Compensation_Scorecard_Response = Put_Compensation_Scorecard_Response;
		}
	}
}
