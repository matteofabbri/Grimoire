using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Event_DocumentsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Event_Documents_ResponseType Get_Event_Documents_Response;

		public Get_Event_DocumentsOutput()
		{
		}

		public Get_Event_DocumentsOutput(Get_Event_Documents_ResponseType Get_Event_Documents_Response)
		{
			this.Get_Event_Documents_Response = Get_Event_Documents_Response;
		}
	}
}
