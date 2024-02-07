using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_CertificationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Certifications_ResponseType Manage_Certifications_Response;

		public Manage_CertificationsOutput()
		{
		}

		public Manage_CertificationsOutput(Manage_Certifications_ResponseType Manage_Certifications_Response)
		{
			this.Manage_Certifications_Response = Manage_Certifications_Response;
		}
	}
}
