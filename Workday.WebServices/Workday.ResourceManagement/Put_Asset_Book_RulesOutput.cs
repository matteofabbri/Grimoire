using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Asset_Book_RulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Asset_Book_Rules_ResponseType Put_Asset_Book_Rules_Response;

		public Put_Asset_Book_RulesOutput()
		{
		}

		public Put_Asset_Book_RulesOutput(Put_Asset_Book_Rules_ResponseType Put_Asset_Book_Rules_Response)
		{
			this.Put_Asset_Book_Rules_Response = Put_Asset_Book_Rules_Response;
		}
	}
}
