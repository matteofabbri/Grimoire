using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Close_Evergreen_RequisitionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Close_Evergreen_Requisition_ResponseType Close_Evergreen_Requisition_Response;

		public Close_Evergreen_RequisitionOutput()
		{
		}

		public Close_Evergreen_RequisitionOutput(Close_Evergreen_Requisition_ResponseType Close_Evergreen_Requisition_Response)
		{
			this.Close_Evergreen_Requisition_Response = Close_Evergreen_Requisition_Response;
		}
	}
}
