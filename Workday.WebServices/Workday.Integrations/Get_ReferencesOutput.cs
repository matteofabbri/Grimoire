using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Integrations
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ReferencesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_References_ResponseType Get_References_Response;

		public Get_ReferencesOutput()
		{
		}

		public Get_ReferencesOutput(Get_References_ResponseType Get_References_Response)
		{
			this.Get_References_Response = Get_References_Response;
		}
	}
}
