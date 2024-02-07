using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Customer_Contract_Change_OrderOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Customer_Contract_Change_Order_ResponseType Submit_Customer_Contract_Change_Order_Response;

		public Submit_Customer_Contract_Change_OrderOutput()
		{
		}

		public Submit_Customer_Contract_Change_OrderOutput(Submit_Customer_Contract_Change_Order_ResponseType Submit_Customer_Contract_Change_Order_Response)
		{
			this.Submit_Customer_Contract_Change_Order_Response = Submit_Customer_Contract_Change_Order_Response;
		}
	}
}
