using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Ad_Hoc_Bank_TransactionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Ad_hoc_Bank_Transaction_ResponseType Submit_Ad_hoc_Bank_Transaction_Response;

		public Submit_Ad_Hoc_Bank_TransactionOutput()
		{
		}

		public Submit_Ad_Hoc_Bank_TransactionOutput(Submit_Ad_hoc_Bank_Transaction_ResponseType Submit_Ad_hoc_Bank_Transaction_Response)
		{
			this.Submit_Ad_hoc_Bank_Transaction_Response = Submit_Ad_hoc_Bank_Transaction_Response;
		}
	}
}
