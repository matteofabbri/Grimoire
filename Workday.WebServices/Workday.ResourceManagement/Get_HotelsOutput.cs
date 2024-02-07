using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_HotelsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Hotels_ResponseType Get_Hotels_Response;

		public Get_HotelsOutput()
		{
		}

		public Get_HotelsOutput(Get_Hotels_ResponseType Get_Hotels_Response)
		{
			this.Get_Hotels_Response = Get_Hotels_Response;
		}
	}
}
