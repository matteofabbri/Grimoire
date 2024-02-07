using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Internal_Service_ProviderOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Internal_Service_Provider_ResponseType Put_Internal_Service_Provider_Response;

		public Put_Internal_Service_ProviderOutput()
		{
		}

		public Put_Internal_Service_ProviderOutput(Put_Internal_Service_Provider_ResponseType Put_Internal_Service_Provider_Response)
		{
			this.Put_Internal_Service_Provider_Response = Put_Internal_Service_Provider_Response;
		}
	}
}
