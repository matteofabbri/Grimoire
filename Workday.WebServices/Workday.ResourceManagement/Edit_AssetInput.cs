using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Edit_AssetInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Edit_Asset_RequestType Edit_Asset_Request;

		public Edit_AssetInput()
		{
		}

		public Edit_AssetInput(Workday_Common_HeaderType Workday_Common_Header, Edit_Asset_RequestType Edit_Asset_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Edit_Asset_Request = Edit_Asset_Request;
		}
	}
}
