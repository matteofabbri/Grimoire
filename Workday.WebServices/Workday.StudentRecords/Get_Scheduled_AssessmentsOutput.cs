using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Scheduled_AssessmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Scheduled_Assessments_ResponseType Get_Scheduled_Assessments_Response;

		public Get_Scheduled_AssessmentsOutput()
		{
		}

		public Get_Scheduled_AssessmentsOutput(Get_Scheduled_Assessments_ResponseType Get_Scheduled_Assessments_Response)
		{
			this.Get_Scheduled_Assessments_Response = Get_Scheduled_Assessments_Response;
		}
	}
}
