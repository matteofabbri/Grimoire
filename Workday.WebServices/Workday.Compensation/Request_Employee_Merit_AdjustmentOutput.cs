using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Request_Employee_Merit_AdjustmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Request_Employee_Merit_Adjustment_ResponseType Request_Employee_Merit_Adjustment_Response;

		public Request_Employee_Merit_AdjustmentOutput()
		{
		}

		public Request_Employee_Merit_AdjustmentOutput(Request_Employee_Merit_Adjustment_ResponseType Request_Employee_Merit_Adjustment_Response)
		{
			this.Request_Employee_Merit_Adjustment_Response = Request_Employee_Merit_Adjustment_Response;
		}
	}
}
