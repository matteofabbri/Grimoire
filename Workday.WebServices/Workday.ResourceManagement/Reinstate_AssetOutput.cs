using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Reinstate_AssetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Reinstate_Asset_ResponseType Reinstate_Asset_Response;

		public Reinstate_AssetOutput()
		{
		}

		public Reinstate_AssetOutput(Reinstate_Asset_ResponseType Reinstate_Asset_Response)
		{
			this.Reinstate_Asset_Response = Reinstate_Asset_Response;
		}
	}
}
