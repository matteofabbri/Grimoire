using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Add_Additional_JobOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Add_Additional_Job_Event_ResponseType Add_Additional_Job_Event_Response;

		public Add_Additional_JobOutput()
		{
		}

		public Add_Additional_JobOutput(Add_Additional_Job_Event_ResponseType Add_Additional_Job_Event_Response)
		{
			this.Add_Additional_Job_Event_Response = Add_Additional_Job_Event_Response;
		}
	}
}
