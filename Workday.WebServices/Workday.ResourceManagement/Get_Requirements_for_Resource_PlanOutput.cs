using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Requirements_for_Resource_PlanOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Requirements_for_Resource_Plan_ResponseType Get_Requirements_for_Resource_Plan_Response;

		public Get_Requirements_for_Resource_PlanOutput()
		{
		}

		public Get_Requirements_for_Resource_PlanOutput(Get_Requirements_for_Resource_Plan_ResponseType Get_Requirements_for_Resource_Plan_Response)
		{
			this.Get_Requirements_for_Resource_Plan_Response = Get_Requirements_for_Resource_Plan_Response;
		}
	}
}
