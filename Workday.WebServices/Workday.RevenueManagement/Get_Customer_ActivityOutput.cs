using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Customer_ActivityOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Customer_Activity_ResponseType Get_Customer_Activity_Response;

		public Get_Customer_ActivityOutput()
		{
		}

		public Get_Customer_ActivityOutput(Get_Customer_Activity_ResponseType Get_Customer_Activity_Response)
		{
			this.Get_Customer_Activity_Response = Get_Customer_Activity_Response;
		}
	}
}
