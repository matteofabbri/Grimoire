using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Project_PlanOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Project_Plan_ResponseType Put_Project_Plan_Response;

		public Put_Project_PlanOutput()
		{
		}

		public Put_Project_PlanOutput(Put_Project_Plan_ResponseType Put_Project_Plan_Response)
		{
			this.Put_Project_Plan_Response = Put_Project_Plan_Response;
		}
	}
}
