using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Future_Payment_Plan_AssignmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Future_Payment_Plan_Assignments_ResponseType Get_Future_Payment_Plan_Assignments_Response;

		public Get_Future_Payment_Plan_AssignmentsOutput()
		{
		}

		public Get_Future_Payment_Plan_AssignmentsOutput(Get_Future_Payment_Plan_Assignments_ResponseType Get_Future_Payment_Plan_Assignments_Response)
		{
			this.Get_Future_Payment_Plan_Assignments_Response = Get_Future_Payment_Plan_Assignments_Response;
		}
	}
}
