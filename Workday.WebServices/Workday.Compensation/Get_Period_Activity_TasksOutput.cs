using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Period_Activity_TasksOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Period_Activity_Tasks_ResponseType Get_Period_Activity_Tasks_Response;

		public Get_Period_Activity_TasksOutput()
		{
		}

		public Get_Period_Activity_TasksOutput(Get_Period_Activity_Tasks_ResponseType Get_Period_Activity_Tasks_Response)
		{
			this.Get_Period_Activity_Tasks_Response = Get_Period_Activity_Tasks_Response;
		}
	}
}
