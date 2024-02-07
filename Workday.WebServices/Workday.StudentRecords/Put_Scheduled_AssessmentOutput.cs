using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Scheduled_AssessmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Scheduled_Assessment_ResponseType Put_Scheduled_Assessment_Response;

		public Put_Scheduled_AssessmentOutput()
		{
		}

		public Put_Scheduled_AssessmentOutput(Put_Scheduled_Assessment_ResponseType Put_Scheduled_Assessment_Response)
		{
			this.Put_Scheduled_Assessment_Response = Put_Scheduled_Assessment_Response;
		}
	}
}
