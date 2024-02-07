using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Learning_OutcomesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Learning_Outcomes_ResponseType Get_Learning_Outcomes_Response;

		public Get_Learning_OutcomesOutput()
		{
		}

		public Get_Learning_OutcomesOutput(Get_Learning_Outcomes_ResponseType Get_Learning_Outcomes_Response)
		{
			this.Get_Learning_Outcomes_Response = Get_Learning_Outcomes_Response;
		}
	}
}
