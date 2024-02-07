using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Internal_Service_ProvidersInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Internal_Service_Providers_RequestType Get_Internal_Service_Providers_Request;

		public Get_Internal_Service_ProvidersInput()
		{
		}

		public Get_Internal_Service_ProvidersInput(Workday_Common_HeaderType Workday_Common_Header, Get_Internal_Service_Providers_RequestType Get_Internal_Service_Providers_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Internal_Service_Providers_Request = Get_Internal_Service_Providers_Request;
		}
	}
}
