using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Job_Posting_SiteOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Job_Posting_Site_ResponseType Put_Job_Posting_Site_Response;

		public Put_Job_Posting_SiteOutput()
		{
		}

		public Put_Job_Posting_SiteOutput(Put_Job_Posting_Site_ResponseType Put_Job_Posting_Site_Response)
		{
			this.Put_Job_Posting_Site_Response = Put_Job_Posting_Site_Response;
		}
	}
}
