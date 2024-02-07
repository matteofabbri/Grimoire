using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Bank_AccountsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Bank_Accounts_ResponseType Get_Bank_Accounts_Response;

		public Get_Bank_AccountsOutput()
		{
		}

		public Get_Bank_AccountsOutput(Get_Bank_Accounts_ResponseType Get_Bank_Accounts_Response)
		{
			this.Get_Bank_Accounts_Response = Get_Bank_Accounts_Response;
		}
	}
}
