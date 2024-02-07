using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assign_Organization_RolesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assign_Organization_Roles_ResponseType Assign_Organization_Roles_Response;

		public Assign_Organization_RolesOutput()
		{
		}

		public Assign_Organization_RolesOutput(Assign_Organization_Roles_ResponseType Assign_Organization_Roles_Response)
		{
			this.Assign_Organization_Roles_Response = Assign_Organization_Roles_Response;
		}
	}
}
