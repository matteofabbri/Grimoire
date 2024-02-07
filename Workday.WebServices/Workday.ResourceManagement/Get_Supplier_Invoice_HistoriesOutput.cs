using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Supplier_Invoice_HistoriesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Supplier_Invoice_Histories_ResponseType Get_Supplier_Invoice_Histories_Response;

		public Get_Supplier_Invoice_HistoriesOutput()
		{
		}

		public Get_Supplier_Invoice_HistoriesOutput(Get_Supplier_Invoice_Histories_ResponseType Get_Supplier_Invoice_Histories_Response)
		{
			this.Get_Supplier_Invoice_Histories_Response = Get_Supplier_Invoice_Histories_Response;
		}
	}
}
