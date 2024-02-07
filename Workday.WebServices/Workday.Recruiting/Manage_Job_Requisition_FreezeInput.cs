using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Job_Requisition_FreezeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Job_Requisition_Freeze_RequestType Manage_Job_Requisition_Freeze_Request;

		public Manage_Job_Requisition_FreezeInput()
		{
		}

		public Manage_Job_Requisition_FreezeInput(Workday_Common_HeaderType Workday_Common_Header, Manage_Job_Requisition_Freeze_RequestType Manage_Job_Requisition_Freeze_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Manage_Job_Requisition_Freeze_Request = Manage_Job_Requisition_Freeze_Request;
		}
	}
}
