using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Move_Job_RequisitionInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Move_Job_Requisition_RequestType Move_Job_Requisition_Request;

		public Move_Job_RequisitionInput()
		{
		}

		public Move_Job_RequisitionInput(Workday_Common_HeaderType Workday_Common_Header, Move_Job_Requisition_RequestType Move_Job_Requisition_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Move_Job_Requisition_Request = Move_Job_Requisition_Request;
		}
	}
}
