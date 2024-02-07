using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Compensation_GradesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Compensation_Grades_ResponseType Get_Compensation_Grades_Response;

		public Get_Compensation_GradesOutput()
		{
		}

		public Get_Compensation_GradesOutput(Get_Compensation_Grades_ResponseType Get_Compensation_Grades_Response)
		{
			this.Get_Compensation_Grades_Response = Get_Compensation_Grades_Response;
		}
	}
}
