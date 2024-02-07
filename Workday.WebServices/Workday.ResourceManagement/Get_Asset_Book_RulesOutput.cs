using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Asset_Book_RulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Asset_Book_Rules_ResponseType Get_Asset_Book_Rules_Response;

		public Get_Asset_Book_RulesOutput()
		{
		}

		public Get_Asset_Book_RulesOutput(Get_Asset_Book_Rules_ResponseType Get_Asset_Book_Rules_Response)
		{
			this.Get_Asset_Book_Rules_Response = Get_Asset_Book_Rules_Response;
		}
	}
}
