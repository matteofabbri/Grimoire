using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Suspend_Asset_DepreciationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Suspend_Asset_Depreciation_ResponseType Suspend_Asset_Depreciation_Response;

		public Suspend_Asset_DepreciationOutput()
		{
		}

		public Suspend_Asset_DepreciationOutput(Suspend_Asset_Depreciation_ResponseType Suspend_Asset_Depreciation_Response)
		{
			this.Suspend_Asset_Depreciation_Response = Suspend_Asset_Depreciation_Response;
		}
	}
}
