using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Basic_ProjectsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Basic_Projects_ResponseType Get_Basic_Projects_Response;

		public Get_Basic_ProjectsOutput()
		{
		}

		public Get_Basic_ProjectsOutput(Get_Basic_Projects_ResponseType Get_Basic_Projects_Response)
		{
			this.Get_Basic_Projects_Response = Get_Basic_Projects_Response;
		}
	}
}
