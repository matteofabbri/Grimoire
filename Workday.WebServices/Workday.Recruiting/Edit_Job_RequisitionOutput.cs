using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Job_RequisitionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Job_Requisition_ResponseType Edit_Job_Requisition_Response;

		public Edit_Job_RequisitionOutput()
		{
		}

		public Edit_Job_RequisitionOutput(Edit_Job_Requisition_ResponseType Edit_Job_Requisition_Response)
		{
			this.Edit_Job_Requisition_Response = Edit_Job_Requisition_Response;
		}
	}
}
