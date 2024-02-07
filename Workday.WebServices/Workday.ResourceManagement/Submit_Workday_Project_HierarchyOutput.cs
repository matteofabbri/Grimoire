using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Workday_Project_HierarchyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Workday_Project_Hierarchy_ResponseType Submit_Workday_Project_Hierarchy_Response;

		public Submit_Workday_Project_HierarchyOutput()
		{
		}

		public Submit_Workday_Project_HierarchyOutput(Submit_Workday_Project_Hierarchy_ResponseType Submit_Workday_Project_Hierarchy_Response)
		{
			this.Submit_Workday_Project_Hierarchy_Response = Submit_Workday_Project_Hierarchy_Response;
		}
	}
}
