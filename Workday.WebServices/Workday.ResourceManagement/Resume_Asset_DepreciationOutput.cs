using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Resume_Asset_DepreciationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Resume_Asset_Depreciation_ResponseType Resume_Asset_Depreciation_Response;

		public Resume_Asset_DepreciationOutput()
		{
		}

		public Resume_Asset_DepreciationOutput(Resume_Asset_Depreciation_ResponseType Resume_Asset_Depreciation_Response)
		{
			this.Resume_Asset_Depreciation_Response = Resume_Asset_Depreciation_Response;
		}
	}
}
