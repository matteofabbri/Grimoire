using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Integration_EventOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Integration_Event_ResponseType Put_Integration_Event_Response;

		public Put_Integration_EventOutput()
		{
		}

		public Put_Integration_EventOutput(Put_Integration_Event_ResponseType Put_Integration_Event_Response)
		{
			this.Put_Integration_Event_Response = Put_Integration_Event_Response;
		}
	}
}
