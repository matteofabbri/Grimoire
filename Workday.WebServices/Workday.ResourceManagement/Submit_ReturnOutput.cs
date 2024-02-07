using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_ReturnOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Return_ResponseType Submit_Return_Response;

		public Submit_ReturnOutput()
		{
		}

		public Submit_ReturnOutput(Submit_Return_ResponseType Submit_Return_Response)
		{
			this.Submit_Return_Response = Submit_Return_Response;
		}
	}
}
