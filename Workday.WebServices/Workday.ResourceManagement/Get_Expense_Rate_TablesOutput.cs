using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Get_Expense_Rate_TablesOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Get_Expense_Rate_Tables_ResponseType Get_Expense_Rate_Tables_Response;

		public Get_Expense_Rate_TablesOutput()
		{
		}

		public Get_Expense_Rate_TablesOutput(Get_Expense_Rate_Tables_ResponseType Get_Expense_Rate_Tables_Response)
		{
			this.Get_Expense_Rate_Tables_Response = Get_Expense_Rate_Tables_Response;
		}
	}
}
