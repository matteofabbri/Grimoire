using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Cash_SaleInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Cash_Sale_RequestType Submit_Cash_Sale_Request;

		public Submit_Cash_SaleInput()
		{
		}

		public Submit_Cash_SaleInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Cash_Sale_RequestType Submit_Cash_Sale_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Cash_Sale_Request = Submit_Cash_Sale_Request;
		}
	}
}
