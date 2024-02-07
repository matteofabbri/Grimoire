using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Funding_Source_RulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Funding_Source_Rules_ResponseType Get_Funding_Source_Rules_Response;

		public Get_Funding_Source_RulesOutput()
		{
		}

		public Get_Funding_Source_RulesOutput(Get_Funding_Source_Rules_ResponseType Get_Funding_Source_Rules_Response)
		{
			this.Get_Funding_Source_Rules_Response = Get_Funding_Source_Rules_Response;
		}
	}
}
