using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Merchant_Customer_ProfileInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Merchant_Customer_Profile_RequestType Get_Merchant_Customer_Profile_Request;

		public Get_Merchant_Customer_ProfileInput()
		{
		}

		public Get_Merchant_Customer_ProfileInput(Workday_Common_HeaderType Workday_Common_Header, Get_Merchant_Customer_Profile_RequestType Get_Merchant_Customer_Profile_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Merchant_Customer_Profile_Request = Get_Merchant_Customer_Profile_Request;
		}
	}
}
