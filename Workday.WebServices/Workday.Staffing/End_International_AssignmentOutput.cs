using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class End_International_AssignmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public End_International_Assignment_for_Employee_Event_ResponseType End_International_Assignment_for_Employee_Event_Response;

		public End_International_AssignmentOutput()
		{
		}

		public End_International_AssignmentOutput(End_International_Assignment_for_Employee_Event_ResponseType End_International_Assignment_for_Employee_Event_Response)
		{
			this.End_International_Assignment_for_Employee_Event_Response = End_International_Assignment_for_Employee_Event_Response;
		}
	}
}
