using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ProfessionalServicesAutomation
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Cancel_Expense_Report_OldInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Expense_Report_CancelType Expense_Report_Cancel;

		public Cancel_Expense_Report_OldInput()
		{
		}

		public Cancel_Expense_Report_OldInput(Workday_Common_HeaderType Workday_Common_Header, Expense_Report_CancelType Expense_Report_Cancel)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Expense_Report_Cancel = Expense_Report_Cancel;
		}
	}
}
