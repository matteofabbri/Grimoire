using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Impair_AssetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Impair_Asset_ResponseType Impair_Asset_Response;

		public Impair_AssetOutput()
		{
		}

		public Impair_AssetOutput(Impair_Asset_ResponseType Impair_Asset_Response)
		{
			this.Impair_Asset_Response = Impair_Asset_Response;
		}
	}
}
