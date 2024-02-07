using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Maintain_Asset_SharesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Maintain_Asset_Shares_RequestType Maintain_Asset_Shares_Request;

		public Maintain_Asset_SharesInput()
		{
		}

		public Maintain_Asset_SharesInput(Workday_Common_HeaderType Workday_Common_Header, Maintain_Asset_Shares_RequestType Maintain_Asset_Shares_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Maintain_Asset_Shares_Request = Maintain_Asset_Shares_Request;
		}
	}
}
