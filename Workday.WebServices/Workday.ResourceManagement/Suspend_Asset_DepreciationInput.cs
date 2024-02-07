using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Suspend_Asset_DepreciationInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Suspend_Asset_Depreciation_RequestType Suspend_Asset_Depreciation_Request;

		public Suspend_Asset_DepreciationInput()
		{
		}

		public Suspend_Asset_DepreciationInput(Workday_Common_HeaderType Workday_Common_Header, Suspend_Asset_Depreciation_RequestType Suspend_Asset_Depreciation_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Suspend_Asset_Depreciation_Request = Suspend_Asset_Depreciation_Request;
		}
	}
}
