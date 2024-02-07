using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Hire_EmployeeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Hire_Employee_Event_ResponseType Hire_Employee_Event_Response;

		public Hire_EmployeeOutput()
		{
		}

		public Hire_EmployeeOutput(Hire_Employee_Event_ResponseType Hire_Employee_Event_Response)
		{
			this.Hire_Employee_Event_Response = Hire_Employee_Event_Response;
		}
	}
}
