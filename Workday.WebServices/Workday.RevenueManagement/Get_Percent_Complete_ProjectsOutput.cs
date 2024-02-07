using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Percent_Complete_ProjectsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Percent_Complete_Projects_ResponseType Get_Percent_Complete_Projects_Response;

		public Get_Percent_Complete_ProjectsOutput()
		{
		}

		public Get_Percent_Complete_ProjectsOutput(Get_Percent_Complete_Projects_ResponseType Get_Percent_Complete_Projects_Response)
		{
			this.Get_Percent_Complete_Projects_Response = Get_Percent_Complete_Projects_Response;
		}
	}
}
