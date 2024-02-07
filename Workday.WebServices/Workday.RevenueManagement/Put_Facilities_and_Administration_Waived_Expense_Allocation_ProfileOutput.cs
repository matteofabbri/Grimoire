using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_ResponseType Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_Response;

		public Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileOutput()
		{
		}

		public Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileOutput(Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_ResponseType Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_Response)
		{
			this.Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_Response = Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_Response;
		}
	}
}
