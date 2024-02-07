using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Expense_ReportOutput
	{
		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Expense_Report_ResponseType Submit_Expense_Report_Response;

		public Submit_Expense_ReportOutput()
		{
		}

		public Submit_Expense_ReportOutput(Submit_Expense_Report_ResponseType Submit_Expense_Report_Response)
		{
			this.Submit_Expense_Report_Response = Submit_Expense_Report_Response;
		}
	}
}
