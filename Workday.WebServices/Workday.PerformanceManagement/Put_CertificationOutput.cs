using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_CertificationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Certification_ResponseType Put_Certification_Response;

		public Put_CertificationOutput()
		{
		}

		public Put_CertificationOutput(Put_Certification_ResponseType Put_Certification_Response)
		{
			this.Put_Certification_Response = Put_Certification_Response;
		}
	}
}
