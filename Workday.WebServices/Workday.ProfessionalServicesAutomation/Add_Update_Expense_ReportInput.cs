using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ProfessionalServicesAutomation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Add_Update_Expense_ReportInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Expense_Report_Add_UpdateType Expense_Report_Add_Update;

		public Add_Update_Expense_ReportInput()
		{
		}

		public Add_Update_Expense_ReportInput(Workday_Common_HeaderType Workday_Common_Header, Expense_Report_Add_UpdateType Expense_Report_Add_Update)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Expense_Report_Add_Update = Expense_Report_Add_Update;
		}
	}
}
