using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Expense_ReportInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Expense_Report_RequestType Submit_Expense_Report_Request;

		public Submit_Expense_ReportInput()
		{
		}

		public Submit_Expense_ReportInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Expense_Report_RequestType Submit_Expense_Report_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Expense_Report_Request = Submit_Expense_Report_Request;
		}
	}
}
