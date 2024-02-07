using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_RequisitionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Requisition_ResponseType Submit_Requisition_Response;

		public Submit_RequisitionOutput()
		{
		}

		public Submit_RequisitionOutput(Submit_Requisition_ResponseType Submit_Requisition_Response)
		{
			this.Submit_Requisition_Response = Submit_Requisition_Response;
		}
	}
}
