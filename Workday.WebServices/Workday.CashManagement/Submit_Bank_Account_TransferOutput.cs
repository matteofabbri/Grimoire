using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Bank_Account_TransferOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Bank_Account_Transfer_ResponseType Submit_Bank_Account_Transfer_Response;

		public Submit_Bank_Account_TransferOutput()
		{
		}

		public Submit_Bank_Account_TransferOutput(Submit_Bank_Account_Transfer_ResponseType Submit_Bank_Account_Transfer_Response)
		{
			this.Submit_Bank_Account_Transfer_Response = Submit_Bank_Account_Transfer_Response;
		}
	}
}
