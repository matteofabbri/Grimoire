using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Travel_ProfilesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Travel_Profiles_ResponseType Get_Travel_Profiles_Response;

		public Get_Travel_ProfilesOutput()
		{
		}

		public Get_Travel_ProfilesOutput(Get_Travel_Profiles_ResponseType Get_Travel_Profiles_Response)
		{
			this.Get_Travel_Profiles_Response = Get_Travel_Profiles_Response;
		}
	}
}
