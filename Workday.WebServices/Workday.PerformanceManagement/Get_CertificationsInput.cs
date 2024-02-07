using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_CertificationsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Certifications_RequestType Get_Certifications_Request;

		public Get_CertificationsInput()
		{
		}

		public Get_CertificationsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Certifications_RequestType Get_Certifications_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Certifications_Request = Get_Certifications_Request;
		}
	}
}
