using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Consolidated_InvoicesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Consolidated_Invoices_RequestType Get_Consolidated_Invoices_Request;

		public Get_Consolidated_InvoicesInput()
		{
		}

		public Get_Consolidated_InvoicesInput(Workday_Common_HeaderType Workday_Common_Header, Get_Consolidated_Invoices_RequestType Get_Consolidated_Invoices_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Consolidated_Invoices_Request = Get_Consolidated_Invoices_Request;
		}
	}
}
