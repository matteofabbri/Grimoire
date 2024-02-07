using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Travel_CityOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Travel_City_ResponseType Put_Travel_City_Response;

		public Put_Travel_CityOutput()
		{
		}

		public Put_Travel_CityOutput(Put_Travel_City_ResponseType Put_Travel_City_Response)
		{
			this.Put_Travel_City_Response = Put_Travel_City_Response;
		}
	}
}
