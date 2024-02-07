using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Recruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Evergreen_RequisitionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Evergreen_Requisitions_ResponseType Get_Evergreen_Requisitions_Response;

		public Get_Evergreen_RequisitionsOutput()
		{
		}

		public Get_Evergreen_RequisitionsOutput(Get_Evergreen_Requisitions_ResponseType Get_Evergreen_Requisitions_Response)
		{
			this.Get_Evergreen_Requisitions_Response = Get_Evergreen_Requisitions_Response;
		}
	}
}
