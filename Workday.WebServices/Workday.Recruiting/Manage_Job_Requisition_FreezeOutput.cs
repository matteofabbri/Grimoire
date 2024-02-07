using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Manage_Job_Requisition_FreezeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Manage_Job_Requisition_Freeze_ResponseType Manage_Job_Requisition_Freeze_Response;

		public Manage_Job_Requisition_FreezeOutput()
		{
		}

		public Manage_Job_Requisition_FreezeOutput(Manage_Job_Requisition_Freeze_ResponseType Manage_Job_Requisition_Freeze_Response)
		{
			this.Manage_Job_Requisition_Freeze_Response = Manage_Job_Requisition_Freeze_Response;
		}
	}
}
