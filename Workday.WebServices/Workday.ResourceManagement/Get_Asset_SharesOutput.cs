using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Asset_SharesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Asset_Shares_ResponseType Get_Asset_Shares_Response;

		public Get_Asset_SharesOutput()
		{
		}

		public Get_Asset_SharesOutput(Get_Asset_Shares_ResponseType Get_Asset_Shares_Response)
		{
			this.Get_Asset_Shares_Response = Get_Asset_Shares_Response;
		}
	}
}
