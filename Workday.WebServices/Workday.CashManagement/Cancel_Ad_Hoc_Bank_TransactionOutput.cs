using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Ad_Hoc_Bank_TransactionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Ad_hoc_Bank_Transaction_ResponseType Cancel_Ad_hoc_Bank_Transaction_Response;

		public Cancel_Ad_Hoc_Bank_TransactionOutput()
		{
		}

		public Cancel_Ad_Hoc_Bank_TransactionOutput(Cancel_Ad_hoc_Bank_Transaction_ResponseType Cancel_Ad_hoc_Bank_Transaction_Response)
		{
			this.Cancel_Ad_hoc_Bank_Transaction_Response = Cancel_Ad_hoc_Bank_Transaction_Response;
		}
	}
}
