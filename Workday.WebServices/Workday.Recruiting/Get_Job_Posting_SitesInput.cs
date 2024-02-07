using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Job_Posting_SitesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Job_Posting_Sites_RequestType Get_Job_Posting_Sites_Request;

		public Get_Job_Posting_SitesInput()
		{
		}

		public Get_Job_Posting_SitesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Posting_Sites_RequestType Get_Job_Posting_Sites_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Job_Posting_Sites_Request = Get_Job_Posting_Sites_Request;
		}
	}
}
