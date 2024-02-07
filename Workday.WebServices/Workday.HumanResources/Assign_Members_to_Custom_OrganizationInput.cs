using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assign_Members_to_Custom_OrganizationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assign_Members_to_Custom_Organization_RequestType Assign_Members_to_Custom_Organization_Request;

		public Assign_Members_to_Custom_OrganizationInput()
		{
		}

		public Assign_Members_to_Custom_OrganizationInput(Workday_Common_HeaderType Workday_Common_Header, Assign_Members_to_Custom_Organization_RequestType Assign_Members_to_Custom_Organization_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Assign_Members_to_Custom_Organization_Request = Assign_Members_to_Custom_Organization_Request;
		}
	}
}
