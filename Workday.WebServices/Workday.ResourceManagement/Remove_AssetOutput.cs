using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Remove_AssetOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Remove_Asset_ResponseType Remove_Asset_Response;

		public Remove_AssetOutput()
		{
		}

		public Remove_AssetOutput(Remove_Asset_ResponseType Remove_Asset_Response)
		{
			this.Remove_Asset_Response = Remove_Asset_Response;
		}
	}
}
