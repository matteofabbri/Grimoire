using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Future_Payment_Plan_AssignmentOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Future_Payment_Plan_Assignment_ResponseType Put_Future_Payment_Plan_Assignment_Response;

		public Put_Future_Payment_Plan_AssignmentOutput()
		{
		}

		public Put_Future_Payment_Plan_AssignmentOutput(Put_Future_Payment_Plan_Assignment_ResponseType Put_Future_Payment_Plan_Assignment_Response)
		{
			this.Put_Future_Payment_Plan_Assignment_Response = Put_Future_Payment_Plan_Assignment_Response;
		}
	}
}
