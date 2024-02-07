using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_CertificationsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Certifications_RequestType Manage_Certifications_Request;

		public Manage_CertificationsInput()
		{
		}

		public Manage_CertificationsInput(Workday_Common_HeaderType Workday_Common_Header, Manage_Certifications_RequestType Manage_Certifications_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Manage_Certifications_Request = Manage_Certifications_Request;
		}
	}
}
