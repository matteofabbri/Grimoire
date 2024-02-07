using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Remove_AssetInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Remove_Asset_RequestType Remove_Asset_Request;

		public Remove_AssetInput()
		{
		}

		public Remove_AssetInput(Workday_Common_HeaderType Workday_Common_Header, Remove_Asset_RequestType Remove_Asset_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Remove_Asset_Request = Remove_Asset_Request;
		}
	}
}
