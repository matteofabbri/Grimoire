using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Supplier_Invoice_ContractInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Supplier_Invoice_Contract_RequestType Submit_Supplier_Invoice_Contract_Request;

		public Submit_Supplier_Invoice_ContractInput()
		{
		}

		public Submit_Supplier_Invoice_ContractInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Supplier_Invoice_Contract_RequestType Submit_Supplier_Invoice_Contract_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Supplier_Invoice_Contract_Request = Submit_Supplier_Invoice_Contract_Request;
		}
	}
}
