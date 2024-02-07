using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Learning_OutcomeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Learning_Outcome_ResponseType Put_Learning_Outcome_Response;

		public Put_Learning_OutcomeOutput()
		{
		}

		public Put_Learning_OutcomeOutput(Put_Learning_Outcome_ResponseType Put_Learning_Outcome_Response)
		{
			this.Put_Learning_Outcome_Response = Put_Learning_Outcome_Response;
		}
	}
}
