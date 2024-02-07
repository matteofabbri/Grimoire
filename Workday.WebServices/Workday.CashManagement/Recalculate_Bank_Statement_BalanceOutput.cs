using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Recalculate_Bank_Statement_BalanceOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Recalculate_Bank_Statement_Balance_ResponseType Recalculate_Bank_Statement_Balance_Response;

		public Recalculate_Bank_Statement_BalanceOutput()
		{
		}

		public Recalculate_Bank_Statement_BalanceOutput(Recalculate_Bank_Statement_Balance_ResponseType Recalculate_Bank_Statement_Balance_Response)
		{
			this.Recalculate_Bank_Statement_Balance_Response = Recalculate_Bank_Statement_Balance_Response;
		}
	}
}
