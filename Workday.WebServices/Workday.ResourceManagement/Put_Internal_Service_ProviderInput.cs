using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Internal_Service_ProviderInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Internal_Service_Provider_RequestType Put_Internal_Service_Provider_Request;

		public Put_Internal_Service_ProviderInput()
		{
		}

		public Put_Internal_Service_ProviderInput(Workday_Common_HeaderType Workday_Common_Header, Put_Internal_Service_Provider_RequestType Put_Internal_Service_Provider_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Internal_Service_Provider_Request = Put_Internal_Service_Provider_Request;
		}
	}
}
