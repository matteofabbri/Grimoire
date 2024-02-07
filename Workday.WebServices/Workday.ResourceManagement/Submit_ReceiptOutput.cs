using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_ReceiptOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Receipt_ResponseType Submit_Receipt_Response;

		public Submit_ReceiptOutput()
		{
		}

		public Submit_ReceiptOutput(Submit_Receipt_ResponseType Submit_Receipt_Response)
		{
			this.Submit_Receipt_Response = Submit_Receipt_Response;
		}
	}
}
