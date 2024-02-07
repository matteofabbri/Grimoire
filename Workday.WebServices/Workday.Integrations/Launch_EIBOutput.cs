using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Launch_EIBOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Launch_EIB_ResponseType Launch_EIB_Response;

		public Launch_EIBOutput()
		{
		}

		public Launch_EIBOutput(Launch_EIB_ResponseType Launch_EIB_Response)
		{
			this.Launch_EIB_Response = Launch_EIB_Response;
		}
	}
}
