using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Update_Asset_Book_ConfigurationOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Update_Asset_Book_Configuration_ResponseType Update_Asset_Book_Configuration_Response;

		public Update_Asset_Book_ConfigurationOutput()
		{
		}

		public Update_Asset_Book_ConfigurationOutput(Update_Asset_Book_Configuration_ResponseType Update_Asset_Book_Configuration_Response)
		{
			this.Update_Asset_Book_Configuration_Response = Update_Asset_Book_Configuration_Response;
		}
	}
}
