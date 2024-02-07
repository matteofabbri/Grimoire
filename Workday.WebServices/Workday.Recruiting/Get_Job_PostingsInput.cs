using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Job_PostingsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Job_Postings_RequestType Get_Job_Postings_Request;

		public Get_Job_PostingsInput()
		{
		}

		public Get_Job_PostingsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Job_Postings_RequestType Get_Job_Postings_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Job_Postings_Request = Get_Job_Postings_Request;
		}
	}
}
