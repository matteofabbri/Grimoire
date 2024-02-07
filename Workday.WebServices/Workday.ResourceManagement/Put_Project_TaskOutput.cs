using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Project_TaskOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Project_Task_ResponseType Put_Project_Task_Response;

		public Put_Project_TaskOutput()
		{
		}

		public Put_Project_TaskOutput(Put_Project_Task_ResponseType Put_Project_Task_Response)
		{
			this.Put_Project_Task_Response = Put_Project_Task_Response;
		}
	}
}
