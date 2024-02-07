using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Asset_Book_RulesInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Asset_Book_Rules_RequestType Put_Asset_Book_Rules_Request;

		public Put_Asset_Book_RulesInput()
		{
		}

		public Put_Asset_Book_RulesInput(Workday_Common_HeaderType Workday_Common_Header, Put_Asset_Book_Rules_RequestType Put_Asset_Book_Rules_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Asset_Book_Rules_Request = Put_Asset_Book_Rules_Request;
		}
	}
}
