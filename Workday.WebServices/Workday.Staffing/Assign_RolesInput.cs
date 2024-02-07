using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assign_RolesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assign_Roles_RequestType Assign_Roles_Request;

		public Assign_RolesInput()
		{
		}

		public Assign_RolesInput(Workday_Common_HeaderType Workday_Common_Header, Assign_Roles_RequestType Assign_Roles_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Assign_Roles_Request = Assign_Roles_Request;
		}
	}
}
