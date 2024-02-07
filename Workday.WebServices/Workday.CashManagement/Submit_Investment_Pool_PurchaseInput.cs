using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.CashManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Investment_Pool_PurchaseInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Investment_Pool_Purchase_RequestType Submit_Investment_Pool_Purchase_Request;

		public Submit_Investment_Pool_PurchaseInput()
		{
		}

		public Submit_Investment_Pool_PurchaseInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Investment_Pool_Purchase_RequestType Submit_Investment_Pool_Purchase_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Investment_Pool_Purchase_Request = Submit_Investment_Pool_Purchase_Request;
		}
	}
}
