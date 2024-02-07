using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_ApplicantInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Applicant_RequestType Put_Applicant_Request;

		public Put_ApplicantInput()
		{
		}

		public Put_ApplicantInput(Workday_Common_HeaderType Workday_Common_Header, Put_Applicant_RequestType Put_Applicant_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Applicant_Request = Put_Applicant_Request;
		}
	}
}
