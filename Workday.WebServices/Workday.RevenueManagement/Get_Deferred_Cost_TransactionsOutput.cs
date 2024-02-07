using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Deferred_Cost_TransactionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Deferred_Cost_Transactions_ResponseType Get_Deferred_Cost_Transactions_Response;

		public Get_Deferred_Cost_TransactionsOutput()
		{
		}

		public Get_Deferred_Cost_TransactionsOutput(Get_Deferred_Cost_Transactions_ResponseType Get_Deferred_Cost_Transactions_Response)
		{
			this.Get_Deferred_Cost_Transactions_Response = Get_Deferred_Cost_Transactions_Response;
		}
	}
}
