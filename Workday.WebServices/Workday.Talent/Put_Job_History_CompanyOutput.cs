using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Job_History_CompanyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Job_History_Company_ResponseType Put_Job_History_Company_Response;

		public Put_Job_History_CompanyOutput()
		{
		}

		public Put_Job_History_CompanyOutput(Put_Job_History_Company_ResponseType Put_Job_History_Company_Response)
		{
			this.Put_Job_History_Company_Response = Put_Job_History_Company_Response;
		}
	}
}
