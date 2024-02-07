using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Job_PostingsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Job_Postings_ResponseType Get_Job_Postings_Response;

		public Get_Job_PostingsOutput()
		{
		}

		public Get_Job_PostingsOutput(Get_Job_Postings_ResponseType Get_Job_Postings_Response)
		{
			this.Get_Job_Postings_Response = Get_Job_Postings_Response;
		}
	}
}
