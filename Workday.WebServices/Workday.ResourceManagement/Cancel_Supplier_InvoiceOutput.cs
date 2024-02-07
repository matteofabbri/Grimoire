using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Supplier_InvoiceOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Supplier_Invoice_ResponseType Cancel_Supplier_Invoice_Response;

		public Cancel_Supplier_InvoiceOutput()
		{
		}

		public Cancel_Supplier_InvoiceOutput(Cancel_Supplier_Invoice_ResponseType Cancel_Supplier_Invoice_Response)
		{
			this.Cancel_Supplier_Invoice_Response = Cancel_Supplier_Invoice_Response;
		}
	}
}
