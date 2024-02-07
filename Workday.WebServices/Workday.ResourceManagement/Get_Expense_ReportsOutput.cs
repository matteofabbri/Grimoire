using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Expense_ReportsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Expense_Reports_ResponseType Get_Expense_Reports_Response;

		public Get_Expense_ReportsOutput()
		{
		}

		public Get_Expense_ReportsOutput(Get_Expense_Reports_ResponseType Get_Expense_Reports_Response)
		{
			this.Get_Expense_Reports_Response = Get_Expense_Reports_Response;
		}
	}
}
