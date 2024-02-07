using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Talent
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_CompetencyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Competency_ResponseType Put_Competency_Response;

		public Put_CompetencyOutput()
		{
		}

		public Put_CompetencyOutput(Put_Competency_ResponseType Put_Competency_Response)
		{
			this.Put_Competency_Response = Put_Competency_Response;
		}
	}
}
