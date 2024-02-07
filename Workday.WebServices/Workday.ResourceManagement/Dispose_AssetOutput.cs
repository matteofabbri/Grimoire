using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Dispose_AssetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Dispose_Asset_ResponseType Dispose_Asset_Response;

		public Dispose_AssetOutput()
		{
		}

		public Dispose_AssetOutput(Dispose_Asset_ResponseType Dispose_Asset_Response)
		{
			this.Dispose_Asset_Response = Dispose_Asset_Response;
		}
	}
}
