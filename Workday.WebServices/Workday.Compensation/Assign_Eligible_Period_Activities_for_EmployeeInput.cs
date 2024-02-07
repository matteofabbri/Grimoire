using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assign_Eligible_Period_Activities_for_EmployeeInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assign_Eligible_Period_Activities_for_Employee_RequestType Assign_Eligible_Period_Activities_for_Employee_Request;

		public Assign_Eligible_Period_Activities_for_EmployeeInput()
		{
		}

		public Assign_Eligible_Period_Activities_for_EmployeeInput(Workday_Common_HeaderType Workday_Common_Header, Assign_Eligible_Period_Activities_for_Employee_RequestType Assign_Eligible_Period_Activities_for_Employee_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Assign_Eligible_Period_Activities_for_Employee_Request = Assign_Eligible_Period_Activities_for_Employee_Request;
		}
	}
}
