using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Position_BudgetsInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Position_Budgets_RequestType Get_Position_Budgets_Request;

		public Get_Position_BudgetsInput()
		{
		}

		public Get_Position_BudgetsInput(Workday_Common_HeaderType Workday_Common_Header, Get_Position_Budgets_RequestType Get_Position_Budgets_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Get_Position_Budgets_Request = Get_Position_Budgets_Request;
		}
	}
}
