using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Integration_MessageOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Integration_Message_ResponseType Put_Integration_Message_Response;

		public Put_Integration_MessageOutput()
		{
		}

		public Put_Integration_MessageOutput(Put_Integration_Message_ResponseType Put_Integration_Message_Response)
		{
			this.Put_Integration_Message_Response = Put_Integration_Message_Response;
		}
	}
}
