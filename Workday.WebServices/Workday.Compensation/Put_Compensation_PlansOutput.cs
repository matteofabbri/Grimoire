using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Compensation_PlansOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Compensation_Plan_ResponseType Put_Compensation_Plan_Response;

		public Put_Compensation_PlansOutput()
		{
		}

		public Put_Compensation_PlansOutput(Put_Compensation_Plan_ResponseType Put_Compensation_Plan_Response)
		{
			this.Put_Compensation_Plan_Response = Put_Compensation_Plan_Response;
		}
	}
}
