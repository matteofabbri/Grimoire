using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_CertificationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Certifications_ResponseType Get_Certifications_Response;

		public Get_CertificationsOutput()
		{
		}

		public Get_CertificationsOutput(Get_Certifications_ResponseType Get_Certifications_Response)
		{
			this.Get_Certifications_Response = Get_Certifications_Response;
		}
	}
}
