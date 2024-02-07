using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_AssetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Asset_ResponseType Edit_Asset_Response;

		public Edit_AssetOutput()
		{
		}

		public Edit_AssetOutput(Edit_Asset_ResponseType Edit_Asset_Response)
		{
			this.Edit_Asset_Response = Edit_Asset_Response;
		}
	}
}
