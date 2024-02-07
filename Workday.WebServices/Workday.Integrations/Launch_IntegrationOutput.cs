using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Launch_IntegrationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Launch_Integration_Event_ResponseType Launch_Integration_Event_Response;

		public Launch_IntegrationOutput()
		{
		}

		public Launch_IntegrationOutput(Launch_Integration_Event_ResponseType Launch_Integration_Event_Response)
		{
			this.Launch_Integration_Event_Response = Launch_Integration_Event_Response;
		}
	}
}
