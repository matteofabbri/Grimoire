using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Car_Rental_AgenciesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Car_Rental_Agencies_ResponseType Get_Car_Rental_Agencies_Response;

		public Get_Car_Rental_AgenciesOutput()
		{
		}

		public Get_Car_Rental_AgenciesOutput(Get_Car_Rental_Agencies_ResponseType Get_Car_Rental_Agencies_Response)
		{
			this.Get_Car_Rental_Agencies_Response = Get_Car_Rental_Agencies_Response;
		}
	}
}
