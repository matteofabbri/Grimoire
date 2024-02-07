using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Project_PhasesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Project_Phases_ResponseType Get_Project_Phases_Response;

		public Get_Project_PhasesOutput()
		{
		}

		public Get_Project_PhasesOutput(Get_Project_Phases_ResponseType Get_Project_Phases_Response)
		{
			this.Get_Project_Phases_Response = Get_Project_Phases_Response;
		}
	}
}
