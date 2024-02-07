using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Petty_Cash_AccountsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Petty_Cash_Accounts_ResponseType Get_Petty_Cash_Accounts_Response;

		public Get_Petty_Cash_AccountsOutput()
		{
		}

		public Get_Petty_Cash_AccountsOutput(Get_Petty_Cash_Accounts_ResponseType Get_Petty_Cash_Accounts_Response)
		{
			this.Get_Petty_Cash_Accounts_Response = Get_Petty_Cash_Accounts_Response;
		}
	}
}
