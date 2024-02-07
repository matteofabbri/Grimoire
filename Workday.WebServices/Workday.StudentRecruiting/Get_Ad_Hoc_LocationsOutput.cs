using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Ad_Hoc_LocationsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Ad_Hoc_Locations_ResponseType Get_Ad_Hoc_Locations_Response;

		public Get_Ad_Hoc_LocationsOutput()
		{
		}

		public Get_Ad_Hoc_LocationsOutput(Get_Ad_Hoc_Locations_ResponseType Get_Ad_Hoc_Locations_Response)
		{
			this.Get_Ad_Hoc_Locations_Response = Get_Ad_Hoc_Locations_Response;
		}
	}
}
