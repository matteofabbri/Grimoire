using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_ReturnsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Returns_ResponseType Get_Returns_Response;

		public Get_ReturnsOutput()
		{
		}

		public Get_ReturnsOutput(Get_Returns_ResponseType Get_Returns_Response)
		{
			this.Get_Returns_Response = Get_Returns_Response;
		}
	}
}
