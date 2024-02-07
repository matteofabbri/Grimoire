using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Add_Retiree_StatusOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Add_Retiree_Status_ResponseType Add_Retiree_Status_Response;

		public Add_Retiree_StatusOutput()
		{
		}

		public Add_Retiree_StatusOutput(Add_Retiree_Status_ResponseType Add_Retiree_Status_Response)
		{
			this.Add_Retiree_Status_Response = Add_Retiree_Status_Response;
		}
	}
}
