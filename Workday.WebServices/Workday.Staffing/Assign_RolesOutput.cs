using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assign_RolesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assign_Roles_ResponseType Assign_Roles_Response;

		public Assign_RolesOutput()
		{
		}

		public Assign_RolesOutput(Assign_Roles_ResponseType Assign_Roles_Response)
		{
			this.Assign_Roles_Response = Assign_Roles_Response;
		}
	}
}
