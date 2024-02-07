using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Consolidated_InvoiceOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Consolidated_Invoice_ResponseType Cancel_Consolidated_Invoice_Response;

		public Cancel_Consolidated_InvoiceOutput()
		{
		}

		public Cancel_Consolidated_InvoiceOutput(Cancel_Consolidated_Invoice_ResponseType Cancel_Consolidated_Invoice_Response)
		{
			this.Cancel_Consolidated_Invoice_Response = Cancel_Consolidated_Invoice_Response;
		}
	}
}
