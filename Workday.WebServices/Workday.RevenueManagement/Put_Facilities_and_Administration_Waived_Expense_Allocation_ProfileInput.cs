using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_RequestType Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_Request;

		public Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileInput()
		{
		}

		public Put_Facilities_and_Administration_Waived_Expense_Allocation_ProfileInput(Workday_Common_HeaderType Workday_Common_Header, Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_RequestType Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_Request = Put_Facilities_and_Administration_Waived_Expense_Allocation_Profile_Request;
		}
	}
}
