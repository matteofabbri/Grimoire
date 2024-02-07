using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Customer_Contract_AmendmentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Customer_Contract_Amendments_ResponseType Get_Customer_Contract_Amendments_Response;

		public Get_Customer_Contract_AmendmentsOutput()
		{
		}

		public Get_Customer_Contract_AmendmentsOutput(Get_Customer_Contract_Amendments_ResponseType Get_Customer_Contract_Amendments_Response)
		{
			this.Get_Customer_Contract_Amendments_Response = Get_Customer_Contract_Amendments_Response;
		}
	}
}
