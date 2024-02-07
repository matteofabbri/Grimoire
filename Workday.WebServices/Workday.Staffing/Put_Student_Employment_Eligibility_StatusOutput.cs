using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Student_Employment_Eligibility_StatusOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Student_Employment_Eligibility_Status_ResponseType Put_Student_Employment_Eligibility_Status_Response;

		public Put_Student_Employment_Eligibility_StatusOutput()
		{
		}

		public Put_Student_Employment_Eligibility_StatusOutput(Put_Student_Employment_Eligibility_Status_ResponseType Put_Student_Employment_Eligibility_Status_Response)
		{
			this.Put_Student_Employment_Eligibility_Status_Response = Put_Student_Employment_Eligibility_Status_Response;
		}
	}
}
