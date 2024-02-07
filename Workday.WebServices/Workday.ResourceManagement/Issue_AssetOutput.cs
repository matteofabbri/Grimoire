using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Issue_AssetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Issue_Asset_ResponseType Issue_Asset_Response;

		public Issue_AssetOutput()
		{
		}

		public Issue_AssetOutput(Issue_Asset_ResponseType Issue_Asset_Response)
		{
			this.Issue_Asset_Response = Issue_Asset_Response;
		}
	}
}
