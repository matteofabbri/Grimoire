using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Cash_SaleInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Cash_Sale_RequestType Cancel_Cash_Sale_Request;

		public Cancel_Cash_SaleInput()
		{
		}

		public Cancel_Cash_SaleInput(Workday_Common_HeaderType Workday_Common_Header, Cancel_Cash_Sale_RequestType Cancel_Cash_Sale_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Cancel_Cash_Sale_Request = Cancel_Cash_Sale_Request;
		}
	}
}
