using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Reinstate_AssetInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Reinstate_Asset_RequestType Reinstate_Asset_Request;

		public Reinstate_AssetInput()
		{
		}

		public Reinstate_AssetInput(Workday_Common_HeaderType Workday_Common_Header, Reinstate_Asset_RequestType Reinstate_Asset_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Reinstate_Asset_Request = Reinstate_Asset_Request;
		}
	}
}
