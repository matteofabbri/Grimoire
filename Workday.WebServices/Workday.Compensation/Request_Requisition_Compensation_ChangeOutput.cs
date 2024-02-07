using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Request_Requisition_Compensation_ChangeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Request_Requisition_Compensation_Change_ResponseType Request_Requisition_Compensation_Change_Response;

		public Request_Requisition_Compensation_ChangeOutput()
		{
		}

		public Request_Requisition_Compensation_ChangeOutput(Request_Requisition_Compensation_Change_ResponseType Request_Requisition_Compensation_Change_Response)
		{
			this.Request_Requisition_Compensation_Change_Response = Request_Requisition_Compensation_Change_Response;
		}
	}
}
