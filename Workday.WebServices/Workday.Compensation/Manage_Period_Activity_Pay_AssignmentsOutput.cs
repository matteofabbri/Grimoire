using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Period_Activity_Pay_AssignmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Period_Activity_Pay_Assignments_ResponseType Manage_Period_Activity_Pay_Assignments_Response;

		public Manage_Period_Activity_Pay_AssignmentsOutput()
		{
		}

		public Manage_Period_Activity_Pay_AssignmentsOutput(Manage_Period_Activity_Pay_Assignments_ResponseType Manage_Period_Activity_Pay_Assignments_Response)
		{
			this.Manage_Period_Activity_Pay_Assignments_Response = Manage_Period_Activity_Pay_Assignments_Response;
		}
	}
}
