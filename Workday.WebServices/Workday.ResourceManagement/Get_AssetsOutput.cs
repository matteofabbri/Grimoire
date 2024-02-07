using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_AssetsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Assets_ResponseType Get_Assets_Response;

		public Get_AssetsOutput()
		{
		}

		public Get_AssetsOutput(Get_Assets_ResponseType Get_Assets_Response)
		{
			this.Get_Assets_Response = Get_Assets_Response;
		}
	}
}
