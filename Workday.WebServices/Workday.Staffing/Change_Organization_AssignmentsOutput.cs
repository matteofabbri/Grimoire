using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Organization_AssignmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Organization_Assignments_ResponseType Change_Organization_Assignments_Response;

		public Change_Organization_AssignmentsOutput()
		{
		}

		public Change_Organization_AssignmentsOutput(Change_Organization_Assignments_ResponseType Change_Organization_Assignments_Response)
		{
			this.Change_Organization_Assignments_Response = Change_Organization_Assignments_Response;
		}
	}
}
