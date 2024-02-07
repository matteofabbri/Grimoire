using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Ledger_Account_SummaryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Ledger_Account_Summary_ResponseType Put_Ledger_Account_Summary_Response;

		public Put_Ledger_Account_SummaryOutput()
		{
		}

		public Put_Ledger_Account_SummaryOutput(Put_Ledger_Account_Summary_ResponseType Put_Ledger_Account_Summary_Response)
		{
			this.Put_Ledger_Account_Summary_Response = Put_Ledger_Account_Summary_Response;
		}
	}
}
