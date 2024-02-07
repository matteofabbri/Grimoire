using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Resume_Asset_DepreciationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Resume_Asset_Depreciation_RequestType Resume_Asset_Depreciation_Request;

		public Resume_Asset_DepreciationInput()
		{
		}

		public Resume_Asset_DepreciationInput(Workday_Common_HeaderType Workday_Common_Header, Resume_Asset_Depreciation_RequestType Resume_Asset_Depreciation_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Resume_Asset_Depreciation_Request = Resume_Asset_Depreciation_Request;
		}
	}
}
