using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Reassign_Superior_to_Inactive_OrganizationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Reassign_Superior_to_Inactive_Organization_ResponseType Reassign_Superior_to_Inactive_Organization_Response;

		public Reassign_Superior_to_Inactive_OrganizationOutput()
		{
		}

		public Reassign_Superior_to_Inactive_OrganizationOutput(Reassign_Superior_to_Inactive_Organization_ResponseType Reassign_Superior_to_Inactive_Organization_Response)
		{
			this.Reassign_Superior_to_Inactive_Organization_Response = Reassign_Superior_to_Inactive_Organization_Response;
		}
	}
}
