using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Spend_AuthorizationsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Spend_Authorizations_RequestType Get_Spend_Authorizations_Request;

		public Get_Spend_AuthorizationsInput()
		{
		}

		public Get_Spend_AuthorizationsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Spend_Authorizations_RequestType Get_Spend_Authorizations_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Spend_Authorizations_Request = Get_Spend_Authorizations_Request;
		}
	}
}
