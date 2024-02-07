using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Request_Employee_Merit_AdjustmentInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Request_Employee_Merit_Adjustment_RequestType Request_Employee_Merit_Adjustment_Request;

		public Request_Employee_Merit_AdjustmentInput()
		{
		}

		public Request_Employee_Merit_AdjustmentInput(Workday_Common_HeaderType Workday_Common_Header, Request_Employee_Merit_Adjustment_RequestType Request_Employee_Merit_Adjustment_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Request_Employee_Merit_Adjustment_Request = Request_Employee_Merit_Adjustment_Request;
		}
	}
}
