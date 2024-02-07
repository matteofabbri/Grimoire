using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Usage_Based_TransactionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Usage_Based_Transactions_ResponseType Get_Usage_Based_Transactions_Response;

		public Get_Usage_Based_TransactionsOutput()
		{
		}

		public Get_Usage_Based_TransactionsOutput(Get_Usage_Based_Transactions_ResponseType Get_Usage_Based_Transactions_Response)
		{
			this.Get_Usage_Based_Transactions_Response = Get_Usage_Based_Transactions_Response;
		}
	}
}
