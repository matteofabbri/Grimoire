using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.HumanResources
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_LocationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Locations_ResponseType Get_Locations_Response;

		public Get_LocationsOutput()
		{
		}

		public Get_LocationsOutput(Get_Locations_ResponseType Get_Locations_Response)
		{
			this.Get_Locations_Response = Get_Locations_Response;
		}
	}
}
