using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Ad_Hoc_Bank_TransactionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Ad_hoc_Bank_Transactions_ResponseType Get_Ad_hoc_Bank_Transactions_Response;

		public Get_Ad_Hoc_Bank_TransactionsOutput()
		{
		}

		public Get_Ad_Hoc_Bank_TransactionsOutput(Get_Ad_hoc_Bank_Transactions_ResponseType Get_Ad_hoc_Bank_Transactions_Response)
		{
			this.Get_Ad_hoc_Bank_Transactions_Response = Get_Ad_hoc_Bank_Transactions_Response;
		}
	}
}
