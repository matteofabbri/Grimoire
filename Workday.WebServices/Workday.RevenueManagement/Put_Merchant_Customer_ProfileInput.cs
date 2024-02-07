using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Merchant_Customer_ProfileInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Merchant_Customer_Profile_RequestType Put_Merchant_Customer_Profile_Request;

		public Put_Merchant_Customer_ProfileInput()
		{
		}

		public Put_Merchant_Customer_ProfileInput(Workday_Common_HeaderType Workday_Common_Header, Put_Merchant_Customer_Profile_RequestType Put_Merchant_Customer_Profile_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Merchant_Customer_Profile_Request = Put_Merchant_Customer_Profile_Request;
		}
	}
}
