using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Medicare_InformationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Medicare_Information_RequestType Manage_Medicare_Information_Request;

		public Manage_Medicare_InformationInput()
		{
		}

		public Manage_Medicare_InformationInput(Workday_Common_HeaderType Workday_Common_Header, Manage_Medicare_Information_RequestType Manage_Medicare_Information_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Manage_Medicare_Information_Request = Manage_Medicare_Information_Request;
		}
	}
}
