using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class End_Additional_JobOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public End_Additional_Employee_Job_Event_ResponseType End_Additional_Employee_Job_Event_Response;

		public End_Additional_JobOutput()
		{
		}

		public End_Additional_JobOutput(End_Additional_Employee_Job_Event_ResponseType End_Additional_Employee_Job_Event_Response)
		{
			this.End_Additional_Employee_Job_Event_Response = End_Additional_Employee_Job_Event_Response;
		}
	}
}
