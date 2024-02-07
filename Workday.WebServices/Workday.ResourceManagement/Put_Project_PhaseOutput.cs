using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Project_PhaseOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Project_Phase_ResponseType Put_Project_Phase_Response;

		public Put_Project_PhaseOutput()
		{
		}

		public Put_Project_PhaseOutput(Put_Project_Phase_ResponseType Put_Project_Phase_Response)
		{
			this.Put_Project_Phase_Response = Put_Project_Phase_Response;
		}
	}
}
