using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.Compensation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Assign_Eligible_Period_Activities_for_EmployeeOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Assign_Eligible_Period_Activities_for_Employee_ResponseType Assign_Eligible_Period_Activities_for_Employee_Response;

		public Assign_Eligible_Period_Activities_for_EmployeeOutput()
		{
		}

		public Assign_Eligible_Period_Activities_for_EmployeeOutput(Assign_Eligible_Period_Activities_for_Employee_ResponseType Assign_Eligible_Period_Activities_for_Employee_Response)
		{
			this.Assign_Eligible_Period_Activities_for_Employee_Response = Assign_Eligible_Period_Activities_for_Employee_Response;
		}
	}
}
