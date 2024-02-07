using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Import_Process_MessagesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Import_Process_Messages_ResponseType Get_Import_Process_Messages_Response;

		public Get_Import_Process_MessagesOutput()
		{
		}

		public Get_Import_Process_MessagesOutput(Get_Import_Process_Messages_ResponseType Get_Import_Process_Messages_Response)
		{
			this.Get_Import_Process_Messages_Response = Get_Import_Process_Messages_Response;
		}
	}
}
