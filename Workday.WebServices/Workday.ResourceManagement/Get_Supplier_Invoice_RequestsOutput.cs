using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Supplier_Invoice_RequestsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Supplier_Invoice_Requests_ResponseType Get_Supplier_Invoice_Requests_Response;

		public Get_Supplier_Invoice_RequestsOutput()
		{
		}

		public Get_Supplier_Invoice_RequestsOutput(Get_Supplier_Invoice_Requests_ResponseType Get_Supplier_Invoice_Requests_Response)
		{
			this.Get_Supplier_Invoice_Requests_Response = Get_Supplier_Invoice_Requests_Response;
		}
	}
}
