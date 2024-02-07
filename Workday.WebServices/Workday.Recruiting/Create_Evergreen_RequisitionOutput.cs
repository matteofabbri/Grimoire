using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Create_Evergreen_RequisitionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Create_Evergreen_Requisition_ResponseType Create_Evergreen_Requisition_Response;

		public Create_Evergreen_RequisitionOutput()
		{
		}

		public Create_Evergreen_RequisitionOutput(Create_Evergreen_Requisition_ResponseType Create_Evergreen_Requisition_Response)
		{
			this.Create_Evergreen_Requisition_Response = Create_Evergreen_Requisition_Response;
		}
	}
}
