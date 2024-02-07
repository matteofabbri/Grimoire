using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Ledger_Account_SummaryInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Ledger_Account_Summary_RequestType Put_Ledger_Account_Summary_Request;

		public Put_Ledger_Account_SummaryInput()
		{
		}

		public Put_Ledger_Account_SummaryInput(Workday_Common_HeaderType Workday_Common_Header, Put_Ledger_Account_Summary_RequestType Put_Ledger_Account_Summary_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Ledger_Account_Summary_Request = Put_Ledger_Account_Summary_Request;
		}
	}
}
