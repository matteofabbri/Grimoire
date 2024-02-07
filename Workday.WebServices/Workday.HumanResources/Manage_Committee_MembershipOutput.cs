using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Committee_MembershipOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Committee_Membership_ResponseType Manage_Committee_Membership_Response;

		public Manage_Committee_MembershipOutput()
		{
		}

		public Manage_Committee_MembershipOutput(Manage_Committee_Membership_ResponseType Manage_Committee_Membership_Response)
		{
			this.Manage_Committee_Membership_Response = Manage_Committee_Membership_Response;
		}
	}
}
