using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Issue_AssetInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Issue_Asset_RequestType Issue_Asset_Request;

		public Issue_AssetInput()
		{
		}

		public Issue_AssetInput(Workday_Common_HeaderType Workday_Common_Header, Issue_Asset_RequestType Issue_Asset_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Issue_Asset_Request = Issue_Asset_Request;
		}
	}
}
