using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Expense_Credit_Card_TransactionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Expense_Credit_Card_Transaction_ResponseType Put_Expense_Credit_Card_Transaction_Response;

		public Put_Expense_Credit_Card_TransactionOutput()
		{
		}

		public Put_Expense_Credit_Card_TransactionOutput(Put_Expense_Credit_Card_Transaction_ResponseType Put_Expense_Credit_Card_Transaction_Response)
		{
			this.Put_Expense_Credit_Card_Transaction_Response = Put_Expense_Credit_Card_Transaction_Response;
		}
	}
}
