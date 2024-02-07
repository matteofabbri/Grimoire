using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Adjust_Asset_CostOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Adjust_Asset_Cost_ResponseType Adjust_Asset_Cost_Response;

		public Adjust_Asset_CostOutput()
		{
		}

		public Adjust_Asset_CostOutput(Adjust_Asset_Cost_ResponseType Adjust_Asset_Cost_Response)
		{
			this.Adjust_Asset_Cost_Response = Adjust_Asset_Cost_Response;
		}
	}
}
