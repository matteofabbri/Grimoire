using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Project_Billing_Rate_SheetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Project_Billing_Rate_Sheet_ResponseType Put_Project_Billing_Rate_Sheet_Response;

		public Put_Project_Billing_Rate_SheetOutput()
		{
		}

		public Put_Project_Billing_Rate_SheetOutput(Put_Project_Billing_Rate_Sheet_ResponseType Put_Project_Billing_Rate_Sheet_Response)
		{
			this.Put_Project_Billing_Rate_Sheet_Response = Put_Project_Billing_Rate_Sheet_Response;
		}
	}
}
