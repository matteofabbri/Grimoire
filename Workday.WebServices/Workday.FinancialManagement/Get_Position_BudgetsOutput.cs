using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Position_BudgetsOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Position_Budgets_ResponseType Get_Position_Budgets_Response;

		public Get_Position_BudgetsOutput()
		{
		}

		public Get_Position_BudgetsOutput(Get_Position_Budgets_ResponseType Get_Position_Budgets_Response)
		{
			this.Get_Position_Budgets_Response = Get_Position_Budgets_Response;
		}
	}
}
