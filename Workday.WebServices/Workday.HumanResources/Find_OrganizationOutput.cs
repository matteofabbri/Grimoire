using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Find_OrganizationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Organization_ReferencesRootType Organization_References;

		public Find_OrganizationOutput()
		{
		}

		public Find_OrganizationOutput(Organization_ReferencesRootType Organization_References)
		{
			this.Organization_References = Organization_References;
		}
	}
}
