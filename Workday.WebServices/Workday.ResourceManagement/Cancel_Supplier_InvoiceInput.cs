using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Supplier_InvoiceInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Supplier_Invoice_RequestType Cancel_Supplier_Invoice_Request;

		public Cancel_Supplier_InvoiceInput()
		{
		}

		public Cancel_Supplier_InvoiceInput(Workday_Common_HeaderType Workday_Common_Header, Cancel_Supplier_Invoice_RequestType Cancel_Supplier_Invoice_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Cancel_Supplier_Invoice_Request = Cancel_Supplier_Invoice_Request;
		}
	}
}
