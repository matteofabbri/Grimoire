using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Asset_Book_ConfigurationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Asset_Book_Configurations_ResponseType Get_Asset_Book_Configurations_Response;

		public Get_Asset_Book_ConfigurationsOutput()
		{
		}

		public Get_Asset_Book_ConfigurationsOutput(Get_Asset_Book_Configurations_ResponseType Get_Asset_Book_Configurations_Response)
		{
			this.Get_Asset_Book_Configurations_Response = Get_Asset_Book_Configurations_Response;
		}
	}
}
