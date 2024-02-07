using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Funding_SourceOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Funding_Source_ResponseType Put_Funding_Source_Response;

		public Put_Funding_SourceOutput()
		{
		}

		public Put_Funding_SourceOutput(Put_Funding_Source_ResponseType Put_Funding_Source_Response)
		{
			this.Put_Funding_Source_Response = Put_Funding_Source_Response;
		}
	}
}
