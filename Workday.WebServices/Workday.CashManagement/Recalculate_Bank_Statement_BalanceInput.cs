using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Recalculate_Bank_Statement_BalanceInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Recalculate_Bank_Statement_Balance_RequestType Recalculate_Bank_Statement_Balance_Request;

		public Recalculate_Bank_Statement_BalanceInput()
		{
		}

		public Recalculate_Bank_Statement_BalanceInput(Workday_Common_HeaderType Workday_Common_Header, Recalculate_Bank_Statement_Balance_RequestType Recalculate_Bank_Statement_Balance_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Recalculate_Bank_Statement_Balance_Request = Recalculate_Bank_Statement_Balance_Request;
		}
	}
}
