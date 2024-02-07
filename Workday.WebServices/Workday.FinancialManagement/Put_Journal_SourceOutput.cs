using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Journal_SourceOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Journal_Source_ResponseType Put_Journal_Source_Response;

		public Put_Journal_SourceOutput()
		{
		}

		public Put_Journal_SourceOutput(Put_Journal_Source_ResponseType Put_Journal_Source_Response)
		{
			this.Put_Journal_Source_Response = Put_Journal_Source_Response;
		}
	}
}
