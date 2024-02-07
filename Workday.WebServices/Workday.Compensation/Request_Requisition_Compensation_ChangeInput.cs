using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Request_Requisition_Compensation_ChangeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Request_Requisition_Compensation_Change_RequestType Request_Requisition_Compensation_Change_Request;

		public Request_Requisition_Compensation_ChangeInput()
		{
		}

		public Request_Requisition_Compensation_ChangeInput(Workday_Common_HeaderType Workday_Common_Header, Request_Requisition_Compensation_Change_RequestType Request_Requisition_Compensation_Change_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Request_Requisition_Compensation_Change_Request = Request_Requisition_Compensation_Change_Request;
		}
	}
}
