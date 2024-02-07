using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Import_Customer_InvoiceInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Import_Customer_Invoice_RequestType Import_Customer_Invoice_Request;

		public Import_Customer_InvoiceInput()
		{
		}

		public Import_Customer_InvoiceInput(Workday_Common_HeaderType Workday_Common_Header, Import_Customer_Invoice_RequestType Import_Customer_Invoice_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Import_Customer_Invoice_Request = Import_Customer_Invoice_Request;
		}
	}
}
