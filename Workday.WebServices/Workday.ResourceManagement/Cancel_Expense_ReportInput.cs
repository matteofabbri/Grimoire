using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Expense_ReportInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Cancel_Expense_Report_RequestType Cancel_Expense_Report_Request;

		public Cancel_Expense_ReportInput()
		{
		}

		public Cancel_Expense_ReportInput(Workday_Common_HeaderType Workday_Common_Header, Cancel_Expense_Report_RequestType Cancel_Expense_Report_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Cancel_Expense_Report_Request = Cancel_Expense_Report_Request;
		}
	}
}
