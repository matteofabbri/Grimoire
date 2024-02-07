using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Ad_Hoc_Billable_TransactionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Ad_Hoc_Billable_Transactions_ResponseType Get_Ad_Hoc_Billable_Transactions_Response;

		public Get_Ad_Hoc_Billable_TransactionsOutput()
		{
		}

		public Get_Ad_Hoc_Billable_TransactionsOutput(Get_Ad_Hoc_Billable_Transactions_ResponseType Get_Ad_Hoc_Billable_Transactions_Response)
		{
			this.Get_Ad_Hoc_Billable_Transactions_Response = Get_Ad_Hoc_Billable_Transactions_Response;
		}
	}
}
