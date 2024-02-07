using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Job_History_CompaniesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Job_History_Companies_ResponseType Get_Job_History_Companies_Response;

		public Get_Job_History_CompaniesOutput()
		{
		}

		public Get_Job_History_CompaniesOutput(Get_Job_History_Companies_ResponseType Get_Job_History_Companies_Response)
		{
			this.Get_Job_History_Companies_Response = Get_Job_History_Companies_Response;
		}
	}
}
