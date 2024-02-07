using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Funding_Source_RuleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Funding_Source_Rule_ResponseType Put_Funding_Source_Rule_Response;

		public Put_Funding_Source_RuleOutput()
		{
		}

		public Put_Funding_Source_RuleOutput(Put_Funding_Source_Rule_ResponseType Put_Funding_Source_Rule_Response)
		{
			this.Put_Funding_Source_Rule_Response = Put_Funding_Source_Rule_Response;
		}
	}
}
