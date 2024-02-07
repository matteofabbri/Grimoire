using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_AirportsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Airports_ResponseType Get_Airports_Response;

		public Get_AirportsOutput()
		{
		}

		public Get_AirportsOutput(Get_Airports_ResponseType Get_Airports_Response)
		{
			this.Get_Airports_Response = Get_Airports_Response;
		}
	}
}
