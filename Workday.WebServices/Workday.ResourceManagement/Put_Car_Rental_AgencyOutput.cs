using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Car_Rental_AgencyOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Car_Rental_Agency_ResponseType Put_Car_Rental_Agency_Response;

		public Put_Car_Rental_AgencyOutput()
		{
		}

		public Put_Car_Rental_AgencyOutput(Put_Car_Rental_Agency_ResponseType Put_Car_Rental_Agency_Response)
		{
			this.Put_Car_Rental_Agency_Response = Put_Car_Rental_Agency_Response;
		}
	}
}
