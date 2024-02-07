using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Ledger_Account_SummariesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Ledger_Account_Summaries_ResponseType Get_Ledger_Account_Summaries_Response;

		public Get_Ledger_Account_SummariesOutput()
		{
		}

		public Get_Ledger_Account_SummariesOutput(Get_Ledger_Account_Summaries_ResponseType Get_Ledger_Account_Summaries_Response)
		{
			this.Get_Ledger_Account_Summaries_Response = Get_Ledger_Account_Summaries_Response;
		}
	}
}
