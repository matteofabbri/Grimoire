using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Register_AssetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Register_Asset_ResponseType Register_Asset_Response;

		public Register_AssetOutput()
		{
		}

		public Register_AssetOutput(Register_Asset_ResponseType Register_Asset_Response)
		{
			this.Register_Asset_Response = Register_Asset_Response;
		}
	}
}
