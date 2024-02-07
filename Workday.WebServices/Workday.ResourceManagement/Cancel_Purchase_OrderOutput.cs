using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Purchase_OrderOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Purchase_Order_ResponseType Cancel_Purchase_Order_Response;

		public Cancel_Purchase_OrderOutput()
		{
		}

		public Cancel_Purchase_OrderOutput(Cancel_Purchase_Order_ResponseType Cancel_Purchase_Order_Response)
		{
			this.Cancel_Purchase_Order_Response = Cancel_Purchase_Order_Response;
		}
	}
}
