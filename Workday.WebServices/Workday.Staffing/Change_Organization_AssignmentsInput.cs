using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Change_Organization_AssignmentsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Change_Organization_Assignments_RequestType Change_Organization_Assignments_Request;

		public Change_Organization_AssignmentsInput()
		{
		}

		public Change_Organization_AssignmentsInput(Workday_Common_HeaderType Workday_Common_Header, Change_Organization_Assignments_RequestType Change_Organization_Assignments_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Change_Organization_Assignments_Request = Change_Organization_Assignments_Request;
		}
	}
}
