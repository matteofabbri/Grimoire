using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Facilities_and_Administration_ExceptionsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Facilities_and_Administration_Exceptions_ResponseType Get_Facilities_and_Administration_Exceptions_Response;

		public Get_Facilities_and_Administration_ExceptionsOutput()
		{
		}

		public Get_Facilities_and_Administration_ExceptionsOutput(Get_Facilities_and_Administration_Exceptions_ResponseType Get_Facilities_and_Administration_Exceptions_Response)
		{
			this.Get_Facilities_and_Administration_Exceptions_Response = Get_Facilities_and_Administration_Exceptions_Response;
		}
	}
}
