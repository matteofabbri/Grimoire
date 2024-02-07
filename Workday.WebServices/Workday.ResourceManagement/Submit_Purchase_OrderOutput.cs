using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Purchase_OrderOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Purchase_Order_ResponseType Submit_Purchase_Order_Response;

		public Submit_Purchase_OrderOutput()
		{
		}

		public Submit_Purchase_OrderOutput(Submit_Purchase_Order_ResponseType Submit_Purchase_Order_Response)
		{
			this.Submit_Purchase_Order_Response = Submit_Purchase_Order_Response;
		}
	}
}
