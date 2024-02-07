using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Supplier_InvoiceOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Supplier_Invoice_ResponseType Submit_Supplier_Invoice_Response;

		public Submit_Supplier_InvoiceOutput()
		{
		}

		public Submit_Supplier_InvoiceOutput(Submit_Supplier_Invoice_ResponseType Submit_Supplier_Invoice_Response)
		{
			this.Submit_Supplier_Invoice_Response = Submit_Supplier_Invoice_Response;
		}
	}
}
