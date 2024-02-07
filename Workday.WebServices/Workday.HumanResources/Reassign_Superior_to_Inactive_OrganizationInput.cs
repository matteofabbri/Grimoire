using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Reassign_Superior_to_Inactive_OrganizationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Reassign_Superior_to_Inactive_Organization_RequestType Reassign_Superior_to_Inactive_Organization_Request;

		public Reassign_Superior_to_Inactive_OrganizationInput()
		{
		}

		public Reassign_Superior_to_Inactive_OrganizationInput(Workday_Common_HeaderType Workday_Common_Header, Reassign_Superior_to_Inactive_Organization_RequestType Reassign_Superior_to_Inactive_Organization_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Reassign_Superior_to_Inactive_Organization_Request = Reassign_Superior_to_Inactive_Organization_Request;
		}
	}
}
