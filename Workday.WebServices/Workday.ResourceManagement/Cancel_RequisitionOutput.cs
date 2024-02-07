using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_RequisitionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Requisition_ResponseType Cancel_Requisition_Response;

		public Cancel_RequisitionOutput()
		{
		}

		public Cancel_RequisitionOutput(Cancel_Requisition_ResponseType Cancel_Requisition_Response)
		{
			this.Cancel_Requisition_Response = Cancel_Requisition_Response;
		}
	}
}
