using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_AirlinesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Airlines_ResponseType Get_Airlines_Response;

		public Get_AirlinesOutput()
		{
		}

		public Get_AirlinesOutput(Get_Airlines_ResponseType Get_Airlines_Response)
		{
			this.Get_Airlines_Response = Get_Airlines_Response;
		}
	}
}
