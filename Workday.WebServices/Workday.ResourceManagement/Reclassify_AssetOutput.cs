using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Reclassify_AssetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Reclassify_Asset_ResponseType Reclassify_Asset_Response;

		public Reclassify_AssetOutput()
		{
		}

		public Reclassify_AssetOutput(Reclassify_Asset_ResponseType Reclassify_Asset_Response)
		{
			this.Reclassify_Asset_Response = Reclassify_Asset_Response;
		}
	}
}
