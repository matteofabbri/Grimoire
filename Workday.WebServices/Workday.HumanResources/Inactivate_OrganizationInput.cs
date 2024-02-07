using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Inactivate_OrganizationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Organization_InactivateType Organization_Inactivate;

		public Inactivate_OrganizationInput()
		{
		}

		public Inactivate_OrganizationInput(Workday_Common_HeaderType Workday_Common_Header, Organization_InactivateType Organization_Inactivate)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Organization_Inactivate = Organization_Inactivate;
		}
	}
}
