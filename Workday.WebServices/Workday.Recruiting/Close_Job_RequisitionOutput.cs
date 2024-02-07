using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Close_Job_RequisitionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Close_Job_Requisition_ResponseType Close_Job_Requisition_Response;

		public Close_Job_RequisitionOutput()
		{
		}

		public Close_Job_RequisitionOutput(Close_Job_Requisition_ResponseType Close_Job_Requisition_Response)
		{
			this.Close_Job_Requisition_Response = Close_Job_Requisition_Response;
		}
	}
}
