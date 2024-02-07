using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Manage_CertificationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Manage_Certifications_ResponseType Get_Manage_Certifications_Response;

		public Get_Manage_CertificationsOutput()
		{
		}

		public Get_Manage_CertificationsOutput(Get_Manage_Certifications_ResponseType Get_Manage_Certifications_Response)
		{
			this.Get_Manage_Certifications_Response = Get_Manage_Certifications_Response;
		}
	}
}
