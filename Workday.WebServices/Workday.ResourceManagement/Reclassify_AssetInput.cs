using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Reclassify_AssetInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Reclassify_Asset_RequestType Reclassify_Asset_Request;

		public Reclassify_AssetInput()
		{
		}

		public Reclassify_AssetInput(Workday_Common_HeaderType Workday_Common_Header, Reclassify_Asset_RequestType Reclassify_Asset_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Reclassify_Asset_Request = Reclassify_Asset_Request;
		}
	}
}
