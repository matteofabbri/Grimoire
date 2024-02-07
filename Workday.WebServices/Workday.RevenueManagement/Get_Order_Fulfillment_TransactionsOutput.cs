using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Order_Fulfillment_TransactionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Order_Fulfillment_Transactions_ResponseType Get_Order_Fulfillment_Transactions_Response;

		public Get_Order_Fulfillment_TransactionsOutput()
		{
		}

		public Get_Order_Fulfillment_TransactionsOutput(Get_Order_Fulfillment_Transactions_ResponseType Get_Order_Fulfillment_Transactions_Response)
		{
			this.Get_Order_Fulfillment_Transactions_Response = Get_Order_Fulfillment_Transactions_Response;
		}
	}
}
