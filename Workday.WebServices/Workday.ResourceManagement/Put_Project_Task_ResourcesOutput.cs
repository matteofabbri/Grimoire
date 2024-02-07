using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Project_Task_ResourcesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Project_Task_Resources_ResponseType Put_Project_Task_Resources_Response;

		public Put_Project_Task_ResourcesOutput()
		{
		}

		public Put_Project_Task_ResourcesOutput(Put_Project_Task_Resources_ResponseType Put_Project_Task_Resources_Response)
		{
			this.Put_Project_Task_Resources_Response = Put_Project_Task_Resources_Response;
		}
	}
}
