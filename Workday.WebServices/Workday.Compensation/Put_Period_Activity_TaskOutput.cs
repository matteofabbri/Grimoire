using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Period_Activity_TaskOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Period_Activity_Task_ResponseType Put_Period_Activity_Task_Response;

		public Put_Period_Activity_TaskOutput()
		{
		}

		public Put_Period_Activity_TaskOutput(Put_Period_Activity_Task_ResponseType Put_Period_Activity_Task_Response)
		{
			this.Put_Period_Activity_Task_Response = Put_Period_Activity_Task_Response;
		}
	}
}
