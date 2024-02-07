using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Add_Update_OrganizationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Organization_Add_UpdateType Organization_Add_Update;

		public Add_Update_OrganizationInput()
		{
		}

		public Add_Update_OrganizationInput(Workday_Common_HeaderType Workday_Common_Header, Organization_Add_UpdateType Organization_Add_Update)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Organization_Add_Update = Organization_Add_Update;
		}
	}
}
