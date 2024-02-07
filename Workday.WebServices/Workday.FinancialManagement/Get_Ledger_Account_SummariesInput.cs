using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Ledger_Account_SummariesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Ledger_Account_Summary_RequestType Get_Ledger_Account_Summary_Request;

		public Get_Ledger_Account_SummariesInput()
		{
		}

		public Get_Ledger_Account_SummariesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Ledger_Account_Summary_RequestType Get_Ledger_Account_Summary_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Ledger_Account_Summary_Request = Get_Ledger_Account_Summary_Request;
		}
	}
}
