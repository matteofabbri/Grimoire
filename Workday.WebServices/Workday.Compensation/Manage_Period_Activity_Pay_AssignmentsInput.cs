using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Period_Activity_Pay_AssignmentsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Period_Activity_Pay_Assignments_RequestType Manage_Period_Activity_Pay_Assignments_Request;

		public Manage_Period_Activity_Pay_AssignmentsInput()
		{
		}

		public Manage_Period_Activity_Pay_AssignmentsInput(Workday_Common_HeaderType Workday_Common_Header, Manage_Period_Activity_Pay_Assignments_RequestType Manage_Period_Activity_Pay_Assignments_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Manage_Period_Activity_Pay_Assignments_Request = Manage_Period_Activity_Pay_Assignments_Request;
		}
	}
}
