using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_InvestorsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Investors_ResponseType Get_Investors_Response;

		public Get_InvestorsOutput()
		{
		}

		public Get_InvestorsOutput(Get_Investors_ResponseType Get_Investors_Response)
		{
			this.Get_Investors_Response = Get_Investors_Response;
		}
	}
}
