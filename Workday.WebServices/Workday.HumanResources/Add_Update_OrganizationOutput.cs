using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Add_Update_OrganizationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Organization_ReferenceRootType Organization_Reference;

		public Add_Update_OrganizationOutput()
		{
		}

		public Add_Update_OrganizationOutput(Organization_ReferenceRootType Organization_Reference)
		{
			this.Organization_Reference = Organization_Reference;
		}
	}
}
