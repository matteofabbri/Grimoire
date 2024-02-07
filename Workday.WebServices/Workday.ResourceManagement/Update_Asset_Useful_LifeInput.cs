using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Update_Asset_Useful_LifeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Update_Asset_Useful_Life_RequestType Update_Asset_Useful_Life_Request;

		public Update_Asset_Useful_LifeInput()
		{
		}

		public Update_Asset_Useful_LifeInput(Workday_Common_HeaderType Workday_Common_Header, Update_Asset_Useful_Life_RequestType Update_Asset_Useful_Life_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Update_Asset_Useful_Life_Request = Update_Asset_Useful_Life_Request;
		}
	}
}
