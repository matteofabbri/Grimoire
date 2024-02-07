using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Create_Job_RequisitionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Create_Job_Requisition_ResponseType Create_Job_Requisition_Response;

		public Create_Job_RequisitionOutput()
		{
		}

		public Create_Job_RequisitionOutput(Create_Job_Requisition_ResponseType Create_Job_Requisition_Response)
		{
			this.Create_Job_Requisition_Response = Create_Job_Requisition_Response;
		}
	}
}
