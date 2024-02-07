using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Customer_Invoice_AdjustmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Customer_Invoice_Adjustments_ResponseType Get_Customer_Invoice_Adjustments_Response;

		public Get_Customer_Invoice_AdjustmentsOutput()
		{
		}

		public Get_Customer_Invoice_AdjustmentsOutput(Get_Customer_Invoice_Adjustments_ResponseType Get_Customer_Invoice_Adjustments_Response)
		{
			this.Get_Customer_Invoice_Adjustments_Response = Get_Customer_Invoice_Adjustments_Response;
		}
	}
}
