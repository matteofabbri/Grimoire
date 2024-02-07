using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Certification_IssuerInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Certification_Issuer_RequestType Put_Certification_Issuer_Request;

		public Put_Certification_IssuerInput()
		{
		}

		public Put_Certification_IssuerInput(Workday_Common_HeaderType Workday_Common_Header, Put_Certification_Issuer_RequestType Put_Certification_Issuer_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Certification_Issuer_Request = Put_Certification_Issuer_Request;
		}
	}
}
