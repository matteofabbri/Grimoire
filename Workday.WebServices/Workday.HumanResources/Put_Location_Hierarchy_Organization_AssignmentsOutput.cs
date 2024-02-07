using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Location_Hierarchy_Organization_AssignmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Location_Hierarchy_Organization_Assignments_ResponseType Put_Location_Hierarchy_Organization_Assignments_Response;

		public Put_Location_Hierarchy_Organization_AssignmentsOutput()
		{
		}

		public Put_Location_Hierarchy_Organization_AssignmentsOutput(Put_Location_Hierarchy_Organization_Assignments_ResponseType Put_Location_Hierarchy_Organization_Assignments_Response)
		{
			this.Put_Location_Hierarchy_Organization_Assignments_Response = Put_Location_Hierarchy_Organization_Assignments_Response;
		}
	}
}
