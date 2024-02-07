using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Location_Hierarchy_Organization_AssignmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Location_Hierarchy_Organization_Assignments_ResponseType Get_Location_Hierarchy_Organization_Assignments_Response;

		public Get_Location_Hierarchy_Organization_AssignmentsOutput()
		{
		}

		public Get_Location_Hierarchy_Organization_AssignmentsOutput(Get_Location_Hierarchy_Organization_Assignments_ResponseType Get_Location_Hierarchy_Organization_Assignments_Response)
		{
			this.Get_Location_Hierarchy_Organization_Assignments_Response = Get_Location_Hierarchy_Organization_Assignments_Response;
		}
	}
}
