using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Maintain_Asset_SharesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Maintain_Asset_Shares_ResponseType Maintain_Asset_Shares_Response;

		public Maintain_Asset_SharesOutput()
		{
		}

		public Maintain_Asset_SharesOutput(Maintain_Asset_Shares_ResponseType Maintain_Asset_Shares_Response)
		{
			this.Maintain_Asset_Shares_Response = Maintain_Asset_Shares_Response;
		}
	}
}
