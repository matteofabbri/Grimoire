using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Facilities_and_Administration_Basis_TypesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Facilities_and_Administration_Basis_Types_ResponseType Get_Facilities_and_Administration_Basis_Types_Response;

		public Get_Facilities_and_Administration_Basis_TypesOutput()
		{
		}

		public Get_Facilities_and_Administration_Basis_TypesOutput(Get_Facilities_and_Administration_Basis_Types_ResponseType Get_Facilities_and_Administration_Basis_Types_Response)
		{
			this.Get_Facilities_and_Administration_Basis_Types_Response = Get_Facilities_and_Administration_Basis_Types_Response;
		}
	}
}
