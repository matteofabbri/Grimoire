using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Consolidated_InvoiceOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Consolidated_Invoice_ResponseType Put_Consolidated_Invoice_Response;

		public Put_Consolidated_InvoiceOutput()
		{
		}

		public Put_Consolidated_InvoiceOutput(Put_Consolidated_Invoice_ResponseType Put_Consolidated_Invoice_Response)
		{
			this.Put_Consolidated_Invoice_Response = Put_Consolidated_Invoice_Response;
		}
	}
}
