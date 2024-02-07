using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Compensation_ScorecardsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Compensation_Scorecards_ResponseType Get_Compensation_Scorecards_Response;

		public Get_Compensation_ScorecardsOutput()
		{
		}

		public Get_Compensation_ScorecardsOutput(Get_Compensation_Scorecards_ResponseType Get_Compensation_Scorecards_Response)
		{
			this.Get_Compensation_Scorecards_Response = Get_Compensation_Scorecards_Response;
		}
	}
}
