using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Travel_CitiesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Travel_Cities_ResponseType Get_Travel_Cities_Response;

		public Get_Travel_CitiesOutput()
		{
		}

		public Get_Travel_CitiesOutput(Get_Travel_Cities_ResponseType Get_Travel_Cities_Response)
		{
			this.Get_Travel_Cities_Response = Get_Travel_Cities_Response;
		}
	}
}
