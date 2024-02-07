using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_Evergreen_RequisitionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Evergreen_Requisition_ResponseType Edit_Evergreen_Requisition_Response;

		public Edit_Evergreen_RequisitionOutput()
		{
		}

		public Edit_Evergreen_RequisitionOutput(Edit_Evergreen_Requisition_ResponseType Edit_Evergreen_Requisition_Response)
		{
			this.Edit_Evergreen_Requisition_Response = Edit_Evergreen_Requisition_Response;
		}
	}
}
