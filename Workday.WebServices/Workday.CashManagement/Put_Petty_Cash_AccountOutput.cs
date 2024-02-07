using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Petty_Cash_AccountOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Petty_Cash_Account_ResponseType Put_Petty_Cash_Account_Response;

		public Put_Petty_Cash_AccountOutput()
		{
		}

		public Put_Petty_Cash_AccountOutput(Put_Petty_Cash_Account_ResponseType Put_Petty_Cash_Account_Response)
		{
			this.Put_Petty_Cash_Account_Response = Put_Petty_Cash_Account_Response;
		}
	}
}
