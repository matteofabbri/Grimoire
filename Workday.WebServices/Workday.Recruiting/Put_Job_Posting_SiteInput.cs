using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Job_Posting_SiteInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Job_Posting_Site_RequestType Put_Job_Posting_Site_Request;

		public Put_Job_Posting_SiteInput()
		{
		}

		public Put_Job_Posting_SiteInput(Workday_Common_HeaderType Workday_Common_Header, Put_Job_Posting_Site_RequestType Put_Job_Posting_Site_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Job_Posting_Site_Request = Put_Job_Posting_Site_Request;
		}
	}
}
