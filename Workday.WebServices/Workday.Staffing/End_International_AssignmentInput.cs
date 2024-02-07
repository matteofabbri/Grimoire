using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class End_International_AssignmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public End_International_Assignment_for_Employee_Event_RequestType End_International_Assignment_for_Employee_Event_Request;

		public End_International_AssignmentInput()
		{
		}

		public End_International_AssignmentInput(Workday_Common_HeaderType Workday_Common_Header, End_International_Assignment_for_Employee_Event_RequestType End_International_Assignment_for_Employee_Event_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.End_International_Assignment_for_Employee_Event_Request = End_International_Assignment_for_Employee_Event_Request;
		}
	}
}
