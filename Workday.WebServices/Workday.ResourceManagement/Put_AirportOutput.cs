using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_AirportOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Airport_ResponseType Put_Airport_Response;

		public Put_AirportOutput()
		{
		}

		public Put_AirportOutput(Put_Airport_ResponseType Put_Airport_Response)
		{
			this.Put_Airport_Response = Put_Airport_Response;
		}
	}
}
