using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_ReceiptOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Receipt_ResponseType Cancel_Receipt_Response;

		public Cancel_ReceiptOutput()
		{
		}

		public Cancel_ReceiptOutput(Cancel_Receipt_ResponseType Cancel_Receipt_Response)
		{
			this.Cancel_Receipt_Response = Cancel_Receipt_Response;
		}
	}
}
