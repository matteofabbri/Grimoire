using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Supplier_Invoice_HistoryOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Supplier_Invoice_History_ResponseType Put_Supplier_Invoice_History_Response;

		public Put_Supplier_Invoice_HistoryOutput()
		{
		}

		public Put_Supplier_Invoice_HistoryOutput(Put_Supplier_Invoice_History_ResponseType Put_Supplier_Invoice_History_Response)
		{
			this.Put_Supplier_Invoice_History_Response = Put_Supplier_Invoice_History_Response;
		}
	}
}
