using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Put_Expense_Rate_Table_RuleOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Put_Expense_Rate_Table_Rule_ResponseType Put_Expense_Rate_Table_Rule_Response;

		public Put_Expense_Rate_Table_RuleOutput()
		{
		}

		public Put_Expense_Rate_Table_RuleOutput(Put_Expense_Rate_Table_Rule_ResponseType Put_Expense_Rate_Table_Rule_Response)
		{
			this.Put_Expense_Rate_Table_Rule_Response = Put_Expense_Rate_Table_Rule_Response;
		}
	}
}
