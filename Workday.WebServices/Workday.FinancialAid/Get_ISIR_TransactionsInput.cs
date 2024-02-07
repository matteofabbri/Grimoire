using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ISIR_TransactionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_ISIR_Transactions_RequestType Get_ISIR_Transactions_Request;

		public Get_ISIR_TransactionsInput()
		{
		}

		public Get_ISIR_TransactionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_ISIR_Transactions_RequestType Get_ISIR_Transactions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_ISIR_Transactions_Request = Get_ISIR_Transactions_Request;
		}
	}
}
