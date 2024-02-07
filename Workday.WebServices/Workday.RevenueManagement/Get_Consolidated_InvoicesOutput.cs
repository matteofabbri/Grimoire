using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Consolidated_InvoicesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Consolidated_Invoices_ResponseType Get_Consolidated_Invoices_Response;

		public Get_Consolidated_InvoicesOutput()
		{
		}

		public Get_Consolidated_InvoicesOutput(Get_Consolidated_Invoices_ResponseType Get_Consolidated_Invoices_Response)
		{
			this.Get_Consolidated_Invoices_Response = Get_Consolidated_Invoices_Response;
		}
	}
}
