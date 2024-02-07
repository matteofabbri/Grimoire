using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Compensation_PlansOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Compensation_Plans_ResponseType Get_Compensation_Plans_Response;

		public Get_Compensation_PlansOutput()
		{
		}

		public Get_Compensation_PlansOutput(Get_Compensation_Plans_ResponseType Get_Compensation_Plans_Response)
		{
			this.Get_Compensation_Plans_Response = Get_Compensation_Plans_Response;
		}
	}
}
