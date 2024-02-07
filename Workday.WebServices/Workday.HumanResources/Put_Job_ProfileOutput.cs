using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Job_ProfileOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Job_Profile_ResponseType Put_Job_Profile_Response;

		public Put_Job_ProfileOutput()
		{
		}

		public Put_Job_ProfileOutput(Put_Job_Profile_ResponseType Put_Job_Profile_Response)
		{
			this.Put_Job_Profile_Response = Put_Job_Profile_Response;
		}
	}
}
