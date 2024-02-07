using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Status_for_ISIR_TransactionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Status_for_ISIR_Transactions_RequestType Import_Status_for_ISIR_Transactions_Request;

		public Import_Status_for_ISIR_TransactionsInput()
		{
		}

		public Import_Status_for_ISIR_TransactionsInput(Workday_Common_HeaderType Workday_Common_Header, Import_Status_for_ISIR_Transactions_RequestType Import_Status_for_ISIR_Transactions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Status_for_ISIR_Transactions_Request = Import_Status_for_ISIR_Transactions_Request;
		}
	}
}
