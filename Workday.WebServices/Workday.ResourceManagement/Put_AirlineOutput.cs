using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_AirlineOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Airline_ResponseType Put_Airline_Response;

		public Put_AirlineOutput()
		{
		}

		public Put_AirlineOutput(Put_Airline_ResponseType Put_Airline_Response)
		{
			this.Put_Airline_Response = Put_Airline_Response;
		}
	}
}
