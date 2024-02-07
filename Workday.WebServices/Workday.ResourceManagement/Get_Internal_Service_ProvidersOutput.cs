using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Internal_Service_ProvidersOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Internal_Service_Providers_ResponseType Get_Internal_Service_Providers_Response;

		public Get_Internal_Service_ProvidersOutput()
		{
		}

		public Get_Internal_Service_ProvidersOutput(Get_Internal_Service_Providers_ResponseType Get_Internal_Service_Providers_Response)
		{
			this.Get_Internal_Service_Providers_Response = Get_Internal_Service_Providers_Response;
		}
	}
}
