using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Dispose_AssetInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Dispose_Asset_RequestType Dispose_Asset_Request;

		public Dispose_AssetInput()
		{
		}

		public Dispose_AssetInput(Workday_Common_HeaderType Workday_Common_Header, Dispose_Asset_RequestType Dispose_Asset_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Dispose_Asset_Request = Dispose_Asset_Request;
		}
	}
}
