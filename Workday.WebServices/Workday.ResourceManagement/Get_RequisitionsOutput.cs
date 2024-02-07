using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_RequisitionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Requisitions_ResponseType Get_Requisitions_Response;

		public Get_RequisitionsOutput()
		{
		}

		public Get_RequisitionsOutput(Get_Requisitions_ResponseType Get_Requisitions_Response)
		{
			this.Get_Requisitions_Response = Get_Requisitions_Response;
		}
	}
}
