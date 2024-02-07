using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Provisioning_Group_AssignmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Provisioning_Group_Assignments_ResponseType Provisioning_Group_Assignments_Response;

		public Get_Provisioning_Group_AssignmentsOutput()
		{
		}

		public Get_Provisioning_Group_AssignmentsOutput(Provisioning_Group_Assignments_ResponseType Provisioning_Group_Assignments_Response)
		{
			this.Provisioning_Group_Assignments_Response = Provisioning_Group_Assignments_Response;
		}
	}
}
