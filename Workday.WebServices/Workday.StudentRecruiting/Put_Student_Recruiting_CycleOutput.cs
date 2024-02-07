using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_Recruiting_CycleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Recruiting_Cycle_ResponseType Put_Student_Recruiting_Cycle_Response;

		public Put_Student_Recruiting_CycleOutput()
		{
		}

		public Put_Student_Recruiting_CycleOutput(Put_Student_Recruiting_Cycle_ResponseType Put_Student_Recruiting_Cycle_Response)
		{
			this.Put_Student_Recruiting_Cycle_Response = Put_Student_Recruiting_Cycle_Response;
		}
	}
}
