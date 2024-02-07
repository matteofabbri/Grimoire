using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Customer_DepositsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Customer_Deposits_ResponseType Get_Customer_Deposits_Response;

		public Get_Customer_DepositsOutput()
		{
		}

		public Get_Customer_DepositsOutput(Get_Customer_Deposits_ResponseType Get_Customer_Deposits_Response)
		{
			this.Get_Customer_Deposits_Response = Get_Customer_Deposits_Response;
		}
	}
}
