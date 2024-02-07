using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Facilities_and_Administration_ExceptionOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Facilities_and_Administration_Exception_ResponseType Put_Facilities_and_Administration_Exception_Response;

		public Put_Facilities_and_Administration_ExceptionOutput()
		{
		}

		public Put_Facilities_and_Administration_ExceptionOutput(Put_Facilities_and_Administration_Exception_ResponseType Put_Facilities_and_Administration_Exception_Response)
		{
			this.Put_Facilities_and_Administration_Exception_Response = Put_Facilities_and_Administration_Exception_Response;
		}
	}
}
