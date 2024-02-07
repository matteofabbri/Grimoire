using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Usage_Based_TransactionsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Usage_Based_Transactions_RequestType Get_Usage_Based_Transactions_Request;

		public Get_Usage_Based_TransactionsInput()
		{
		}

		public Get_Usage_Based_TransactionsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Usage_Based_Transactions_RequestType Get_Usage_Based_Transactions_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Usage_Based_Transactions_Request = Get_Usage_Based_Transactions_Request;
		}
	}
}
