using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ApplicantsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Applicants_RequestType Get_Applicants_Request;

		public Get_ApplicantsInput()
		{
		}

		public Get_ApplicantsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Applicants_RequestType Get_Applicants_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Applicants_Request = Get_Applicants_Request;
		}
	}
}
