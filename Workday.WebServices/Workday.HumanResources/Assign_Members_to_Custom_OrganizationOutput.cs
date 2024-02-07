using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assign_Members_to_Custom_OrganizationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assign_Members_to_Custom_Organization_ResponseType Assign_Members_to_Custom_Organization_Response;

		public Assign_Members_to_Custom_OrganizationOutput()
		{
		}

		public Assign_Members_to_Custom_OrganizationOutput(Assign_Members_to_Custom_Organization_ResponseType Assign_Members_to_Custom_Organization_Response)
		{
			this.Assign_Members_to_Custom_Organization_Response = Assign_Members_to_Custom_Organization_Response;
		}
	}
}
