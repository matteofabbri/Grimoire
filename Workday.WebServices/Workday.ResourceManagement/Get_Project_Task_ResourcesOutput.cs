using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Project_Task_ResourcesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Project_Task_Resources_ResponseType Get_Project_Task_Resources_Response;

		public Get_Project_Task_ResourcesOutput()
		{
		}

		public Get_Project_Task_ResourcesOutput(Get_Project_Task_Resources_ResponseType Get_Project_Task_Resources_Response)
		{
			this.Get_Project_Task_Resources_Response = Get_Project_Task_Resources_Response;
		}
	}
}
