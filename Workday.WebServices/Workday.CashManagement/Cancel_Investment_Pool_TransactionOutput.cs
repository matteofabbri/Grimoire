using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Investment_Pool_TransactionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Investment_Pool_Transaction_ResponseType Cancel_Investment_Pool_Transaction_Response;

		public Cancel_Investment_Pool_TransactionOutput()
		{
		}

		public Cancel_Investment_Pool_TransactionOutput(Cancel_Investment_Pool_Transaction_ResponseType Cancel_Investment_Pool_Transaction_Response)
		{
			this.Cancel_Investment_Pool_Transaction_Response = Cancel_Investment_Pool_Transaction_Response;
		}
	}
}
