using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Resource_PlanOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Resource_Plan_ResponseType Submit_Resource_Plan_Response;

		public Submit_Resource_PlanOutput()
		{
		}

		public Submit_Resource_PlanOutput(Submit_Resource_Plan_ResponseType Submit_Resource_Plan_Response)
		{
			this.Submit_Resource_Plan_Response = Submit_Resource_Plan_Response;
		}
	}
}
