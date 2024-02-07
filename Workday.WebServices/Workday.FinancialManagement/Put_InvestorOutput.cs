using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_InvestorOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Investor_ResponseType Put_Investor_Response;

		public Put_InvestorOutput()
		{
		}

		public Put_InvestorOutput(Put_Investor_ResponseType Put_Investor_Response)
		{
			this.Put_Investor_Response = Put_Investor_Response;
		}
	}
}
