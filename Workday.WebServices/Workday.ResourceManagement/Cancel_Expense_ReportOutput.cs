using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Expense_ReportOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Expense_Report_ResponseType Cancel_Expense_Report_Response;

		public Cancel_Expense_ReportOutput()
		{
		}

		public Cancel_Expense_ReportOutput(Cancel_Expense_Report_ResponseType Cancel_Expense_Report_Response)
		{
			this.Cancel_Expense_Report_Response = Cancel_Expense_Report_Response;
		}
	}
}
