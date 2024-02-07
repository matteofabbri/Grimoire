using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Expense_Rate_Table_RulesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Expense_Rate_Table_Rules_ResponseType Get_Expense_Rate_Table_Rules_Response;

		public Get_Expense_Rate_Table_RulesOutput()
		{
		}

		public Get_Expense_Rate_Table_RulesOutput(Get_Expense_Rate_Table_Rules_ResponseType Get_Expense_Rate_Table_Rules_Response)
		{
			this.Get_Expense_Rate_Table_Rules_Response = Get_Expense_Rate_Table_Rules_Response;
		}
	}
}
