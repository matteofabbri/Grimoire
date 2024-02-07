using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Union_MembershipOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Union_Membership_ResponseType Manage_Union_Membership_Response;

		public Manage_Union_MembershipOutput()
		{
		}

		public Manage_Union_MembershipOutput(Manage_Union_Membership_ResponseType Manage_Union_Membership_Response)
		{
			this.Manage_Union_Membership_Response = Manage_Union_Membership_Response;
		}
	}
}
