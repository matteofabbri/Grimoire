using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Staffing
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Hire_EmployeeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Hire_Employee_RequestType Hire_Employee_Request;

		public Hire_EmployeeInput()
		{
		}

		public Hire_EmployeeInput(Workday_Common_HeaderType Workday_Common_Header, Hire_Employee_RequestType Hire_Employee_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Hire_Employee_Request = Hire_Employee_Request;
		}
	}
}
