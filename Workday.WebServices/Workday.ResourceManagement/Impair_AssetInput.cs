using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Impair_AssetInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Impair_Asset_RequestType Impair_Asset_Request;

		public Impair_AssetInput()
		{
		}

		public Impair_AssetInput(Workday_Common_HeaderType Workday_Common_Header, Impair_Asset_RequestType Impair_Asset_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Impair_Asset_Request = Impair_Asset_Request;
		}
	}
}
