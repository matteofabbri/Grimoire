using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Investment_Pool_TransferOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Investment_Pool_Transfer_ResponseType Submit_Investment_Pool_Transfer_Response;

		public Submit_Investment_Pool_TransferOutput()
		{
		}

		public Submit_Investment_Pool_TransferOutput(Submit_Investment_Pool_Transfer_ResponseType Submit_Investment_Pool_Transfer_Response)
		{
			this.Submit_Investment_Pool_Transfer_Response = Submit_Investment_Pool_Transfer_Response;
		}
	}
}
