using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Union_MembershipInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Union_Membership_RequestType Manage_Union_Membership_Request;

		public Manage_Union_MembershipInput()
		{
		}

		public Manage_Union_MembershipInput(Workday_Common_HeaderType Workday_Common_Header, Manage_Union_Membership_RequestType Manage_Union_Membership_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Manage_Union_Membership_Request = Manage_Union_Membership_Request;
		}
	}
}
