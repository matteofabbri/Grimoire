using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Supplier_Invoice_RequestOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Supplier_Invoice_Request_ResponseType Submit_Supplier_Invoice_Request_Response;

		public Submit_Supplier_Invoice_RequestOutput()
		{
		}

		public Submit_Supplier_Invoice_RequestOutput(Submit_Supplier_Invoice_Request_ResponseType Submit_Supplier_Invoice_Request_Response)
		{
			this.Submit_Supplier_Invoice_Request_Response = Submit_Supplier_Invoice_Request_Response;
		}
	}
}
