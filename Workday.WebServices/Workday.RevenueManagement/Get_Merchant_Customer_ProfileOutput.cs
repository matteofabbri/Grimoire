using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Merchant_Customer_ProfileOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Merchant_Customer_Profile_ResponseType Get_Merchant_Customer_Profile_Response;

		public Get_Merchant_Customer_ProfileOutput()
		{
		}

		public Get_Merchant_Customer_ProfileOutput(Get_Merchant_Customer_Profile_ResponseType Get_Merchant_Customer_Profile_Response)
		{
			this.Get_Merchant_Customer_Profile_Response = Get_Merchant_Customer_Profile_Response;
		}
	}
}
