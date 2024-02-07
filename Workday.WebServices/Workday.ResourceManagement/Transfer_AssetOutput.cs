using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Transfer_AssetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Transfer_Asset_ResponseType Transfer_Asset_Response;

		public Transfer_AssetOutput()
		{
		}

		public Transfer_AssetOutput(Transfer_Asset_ResponseType Transfer_Asset_Response)
		{
			this.Transfer_Asset_Response = Transfer_Asset_Response;
		}
	}
}
