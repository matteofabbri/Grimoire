using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Import_ProcessesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Import_Processes_ResponseType Get_Import_Processes_Response;

		public Get_Import_ProcessesOutput()
		{
		}

		public Get_Import_ProcessesOutput(Get_Import_Processes_ResponseType Get_Import_Processes_Response)
		{
			this.Get_Import_Processes_Response = Get_Import_Processes_Response;
		}
	}
}
