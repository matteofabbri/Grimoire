using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Headcount_Plan_StructuresOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Headcount_Plan_Structures_ResponseType Get_Headcount_Plan_Structures_Response;

		public Get_Headcount_Plan_StructuresOutput()
		{
		}

		public Get_Headcount_Plan_StructuresOutput(Get_Headcount_Plan_Structures_ResponseType Get_Headcount_Plan_Structures_Response)
		{
			this.Get_Headcount_Plan_Structures_Response = Get_Headcount_Plan_Structures_Response;
		}
	}
}
