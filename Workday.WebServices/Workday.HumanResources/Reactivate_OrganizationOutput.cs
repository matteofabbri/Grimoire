using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Reactivate_OrganizationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Reactivate_Organization_ResponseType Reactivate_Organization_Response;

		public Reactivate_OrganizationOutput()
		{
		}

		public Reactivate_OrganizationOutput(Reactivate_Organization_ResponseType Reactivate_Organization_Response)
		{
			this.Reactivate_Organization_Response = Reactivate_Organization_Response;
		}
	}
}
