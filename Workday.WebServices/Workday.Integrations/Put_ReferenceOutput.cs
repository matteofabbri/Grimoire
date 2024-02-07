using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_ReferenceOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Reference_ResponseType Put_Reference_Response;

		public Put_ReferenceOutput()
		{
		}

		public Put_ReferenceOutput(Put_Reference_ResponseType Put_Reference_Response)
		{
			this.Put_Reference_Response = Put_Reference_Response;
		}
	}
}
