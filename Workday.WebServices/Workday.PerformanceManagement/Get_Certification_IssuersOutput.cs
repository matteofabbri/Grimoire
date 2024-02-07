using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Certification_IssuersOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Certification_Issuers_ResponseType Get_Certification_Issuers_Response;

		public Get_Certification_IssuersOutput()
		{
		}

		public Get_Certification_IssuersOutput(Get_Certification_Issuers_ResponseType Get_Certification_Issuers_Response)
		{
			this.Get_Certification_Issuers_Response = Get_Certification_Issuers_Response;
		}
	}
}
