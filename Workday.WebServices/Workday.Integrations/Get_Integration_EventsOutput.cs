using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Integration_EventsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Integration_Events_ResponseType Get_Integration_Events_Response;

		public Get_Integration_EventsOutput()
		{
		}

		public Get_Integration_EventsOutput(Get_Integration_Events_ResponseType Get_Integration_Events_Response)
		{
			this.Get_Integration_Events_Response = Get_Integration_Events_Response;
		}
	}
}
