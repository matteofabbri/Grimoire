using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Journal_SourcesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Journal_Sources_ResponseType Get_Journal_Sources_Response;

		public Get_Journal_SourcesOutput()
		{
		}

		public Get_Journal_SourcesOutput(Get_Journal_Sources_ResponseType Get_Journal_Sources_Response)
		{
			this.Get_Journal_Sources_Response = Get_Journal_Sources_Response;
		}
	}
}
