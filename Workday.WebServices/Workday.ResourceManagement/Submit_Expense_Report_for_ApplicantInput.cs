using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(IsWrapped = false)]
	public class Submit_Expense_Report_for_ApplicantInput
	{
		[MessageHeader(Namespace = "urn:com.workday/bsvc")]
		public Workday_Common_HeaderType Workday_Common_Header;

		[MessageBodyMember(Namespace = "urn:com.workday/bsvc", Order = 0)]
		public Submit_Expense_Report_for_Applicant_RequestType Submit_Expense_Report_for_Applicant_Request;

		public Submit_Expense_Report_for_ApplicantInput()
		{
		}

		public Submit_Expense_Report_for_ApplicantInput(Workday_Common_HeaderType Workday_Common_Header, Submit_Expense_Report_for_Applicant_RequestType Submit_Expense_Report_for_Applicant_Request)
		{
			this.Workday_Common_Header = Workday_Common_Header;
			this.Submit_Expense_Report_for_Applicant_Request = Submit_Expense_Report_for_Applicant_Request;
		}
	}
}
