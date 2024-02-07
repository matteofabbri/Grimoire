using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Compensation_Scorecard_ResultOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Compensation_Scorecard_Result_ResponseType Put_Compensation_Scorecard_Result_Response;

		public Put_Compensation_Scorecard_ResultOutput()
		{
		}

		public Put_Compensation_Scorecard_ResultOutput(Put_Compensation_Scorecard_Result_ResponseType Put_Compensation_Scorecard_Result_Response)
		{
			this.Put_Compensation_Scorecard_Result_Response = Put_Compensation_Scorecard_Result_Response;
		}
	}
}
