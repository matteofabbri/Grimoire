using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Requirements_for_Resource_PlanOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Requirements_for_Resource_Plan_Line_ResponseType Put_Requirements_for_Resource_Plan_Line_Response;

		public Put_Requirements_for_Resource_PlanOutput()
		{
		}

		public Put_Requirements_for_Resource_PlanOutput(Put_Requirements_for_Resource_Plan_Line_ResponseType Put_Requirements_for_Resource_Plan_Line_Response)
		{
			this.Put_Requirements_for_Resource_Plan_Line_Response = Put_Requirements_for_Resource_Plan_Line_Response;
		}
	}
}
