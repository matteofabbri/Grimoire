using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Asset_Book_ConfigurationsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Asset_Book_Configurations_RequestType Get_Asset_Book_Configurations_Request;

		public Get_Asset_Book_ConfigurationsInput()
		{
		}

		public Get_Asset_Book_ConfigurationsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Asset_Book_Configurations_RequestType Get_Asset_Book_Configurations_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Asset_Book_Configurations_Request = Get_Asset_Book_Configurations_Request;
		}
	}
}
