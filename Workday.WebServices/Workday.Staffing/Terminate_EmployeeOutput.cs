using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Terminate_EmployeeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Terminate_Employee_Event_ResponseType Terminate_Employee_Event_Response;

		public Terminate_EmployeeOutput()
		{
		}

		public Terminate_EmployeeOutput(Terminate_Employee_Event_ResponseType Terminate_Employee_Event_Response)
		{
			this.Terminate_Employee_Event_Response = Terminate_Employee_Event_Response;
		}
	}
}
