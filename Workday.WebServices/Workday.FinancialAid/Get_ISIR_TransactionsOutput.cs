using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ISIR_TransactionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_ISIR_Transactions_ResponseType Get_ISIR_Transactions_Response;

		public Get_ISIR_TransactionsOutput()
		{
		}

		public Get_ISIR_TransactionsOutput(Get_ISIR_Transactions_ResponseType Get_ISIR_Transactions_Response)
		{
			this.Get_ISIR_Transactions_Response = Get_ISIR_Transactions_Response;
		}
	}
}
