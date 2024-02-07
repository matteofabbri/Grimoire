using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Switch_Primary_JobOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Switch_Primary_Job_Event_ResponseType Switch_Primary_Job_Event_Response;

		public Switch_Primary_JobOutput()
		{
		}

		public Switch_Primary_JobOutput(Switch_Primary_Job_Event_ResponseType Switch_Primary_Job_Event_Response)
		{
			this.Switch_Primary_Job_Event_Response = Switch_Primary_Job_Event_Response;
		}
	}
}
